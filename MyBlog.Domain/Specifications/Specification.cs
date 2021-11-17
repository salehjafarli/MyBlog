using MyBlog.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Specifications
{
    public class Specification<T> where T : Entity
    {
        private Expression<Func<T, bool>> Expression { get; set; }

        public Specification(Expression<Func<T, bool>> Expression)
        {
            this.Expression = Expression;
        }
        public bool IsSatisifiedBy(T Entity)
        {
            return Expression.Compile().Invoke(Entity);
        }

    }
}
