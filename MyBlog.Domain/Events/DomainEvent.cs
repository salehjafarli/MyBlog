using MediatR;
using MyBlog.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Events
{
    public abstract class DomainEvent: INotification 
    {
        public DomainEvent(Entity Entity,DateTime EventDate)
        {
            this.Entity = Entity;
            this.EventDate = EventDate;
        }
        public Entity Entity { get; set; }
        public DateTime EventDate { get; set; }
    }
}
