using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Queries.Article
{
    public class QueryRecentArticles : IRequest<ICollection<Entites.Article>>
    {
        public QueryRecentArticles(int Amount)
        {
            this.Amount = Amount;
        }
        public int Amount { get; set; }
    }
}
