using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Repositories
{
    public interface IOptionRepository
    {
        public Task<T> GetValue<T>(string key);
        public Task SetValue(string key,object value);
    }
}
