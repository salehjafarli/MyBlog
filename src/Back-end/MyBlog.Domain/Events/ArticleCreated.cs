using MyBlog.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Events
{
    public class ArticleCreated : DomainEvent
    {
        public ArticleCreated(Article Entity,DateTime EventDate) : base(Entity,EventDate)
        {

        }
    }
}
