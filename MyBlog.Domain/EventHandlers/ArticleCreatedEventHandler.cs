using MediatR;
using MyBlog.Domain.Entites;
using MyBlog.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBlog.Domain.EventHandlers
{
    public class ArticleCreatedEventHandler : IEventHandler<ArticleCreated>
    {
        public ArticleCreatedEventHandler()
        {

        }
        public Task Handle(ArticleCreated notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
