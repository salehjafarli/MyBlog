using MyBlog.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Repositories
{
    public interface IArticleRepository : IRepository<Article>
    {
        Task<ICollection<Article>> GetByCategory(string category);
        Task<ICollection<Article>> GetMostRecent(int amount);
    }
}
