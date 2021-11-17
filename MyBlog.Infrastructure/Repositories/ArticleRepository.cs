using MyBlog.Domain.Entites;
using MyBlog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructure.Repositories
{
    class ArticleRepository : IArticleRepository
    {
        public Task<bool> Create(Article Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Article>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Article> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Article Entity)
        {
            throw new NotImplementedException();
        }
    }
}
