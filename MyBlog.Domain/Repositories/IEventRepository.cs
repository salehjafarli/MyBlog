using MyBlog.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Repositories
{
    public interface IEventRepository<T> where T : DomainEvent
    {
        public Task<bool> Add(T @event);
    }
}
