using MediatR;
using MyBlog.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Queries.Article
{
    
    public class QueryArticleByCategory : IRequest<ICollection<Entites.Article>> 
    {
        public QueryArticleByCategory(string Category)
        {
            this.Category = Category;
        }
        public string Category { get; set; }
    }
}
