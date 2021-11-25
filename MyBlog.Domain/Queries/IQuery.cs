using MediatR;
using MyBlog.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Queries
{
    public interface IQuery<T> : IRequest<ICollection<T>> where T : Entity
    {

    }
}
