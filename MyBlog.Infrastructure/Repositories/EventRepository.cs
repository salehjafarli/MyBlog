using MyBlog.Domain.Events;
using MyBlog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {
        public Task<bool> Add<T>(T @event) where T : DomainEvent
        {
            throw new NotImplementedException();
        }
    }
}
