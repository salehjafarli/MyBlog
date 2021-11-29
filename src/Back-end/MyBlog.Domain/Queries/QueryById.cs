using MediatR;
using MyBlog.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Queries
{
    public class QueryById<T> : IRequest<T> where T : Entity
    {
        public QueryById(int Id)
        {
            this.Id = Id;
        }
        public int Id { get; set; }
    }
}
