using MyBlog.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.EventDispatchers
{
    public interface IEventDispatcher 
    {
        public Task RaiseEvent<T>(T @event) where T : DomainEvent;
    }
}
