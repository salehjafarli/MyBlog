using MediatR;
using MyBlog.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.EventDispatchers
{
    public class EventDispatcher : IEventDispatcher
    {
        public EventDispatcher(IMediator Mediator)
        {
            this.Mediator = Mediator;
        }

        public IMediator Mediator { get; }

        public async Task RaiseEvent<T>(T @event) where T : DomainEvent
        {
            await Mediator.Publish(@event);
        }
    }
}
