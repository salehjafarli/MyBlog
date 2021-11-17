using MyBlog.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        public Task<bool> Create(T Entity);
        public Task<bool> Update(T Entity);
        public Task<bool> Delete(int Id);
        public Task<T> GetById(int Id);
        public Task<IEnumerable<T>> Get();

    }
}
