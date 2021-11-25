using MediatR;
using MyBlog.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Queries
{
    public class QueryAll<T> : IQuery<T> where T : Entity
    {

    }
}
