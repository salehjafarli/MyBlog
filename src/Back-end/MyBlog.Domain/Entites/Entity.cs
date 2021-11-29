using MyBlog.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Entites
{
    public abstract class Entity
    {
        public int Id { get; set; }
        private List<DomainEvent> Events { get; set; } = new List<DomainEvent>();

        public void AddEvent(DomainEvent @event)
        {
            Events.Add(@event);
        }

        public void ClearEvents()
        {
            Events.Clear();
        }
    }
}
