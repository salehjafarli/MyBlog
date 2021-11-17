using MediatR;
using MyBlog.Domain.Entites;
using MyBlog.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.EventHandlers
{
    public interface IEventHandler<TEvent> : INotificationHandler<TEvent> where TEvent : DomainEvent
    { 

    }
}
