using MyBlog.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entities = MyBlog.Domain.Entites;

namespace MyBlog.Domain.QueryHandlers.Article
{
    public class ArticleQueryHandler : IQueryHandler<QueryById<Entities.Article>>
    {
        
    }
}
