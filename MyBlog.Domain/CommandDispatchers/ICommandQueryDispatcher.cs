using MediatR;
using MyBlog.Domain.Commands;
using MyBlog.Domain.Entites;
using MyBlog.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.CommandDispatchers
{
    public interface ICommandQueryDispatcher
    {
        public Task<bool> ExecuteCommand<T>(T Command) where T : ICommand;
        public Task<T> ExecuteQuery<T>(IRequest<T> Query);
    }
}
