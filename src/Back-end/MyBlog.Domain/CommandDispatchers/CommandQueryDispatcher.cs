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
    public class CommandQueryDispatcher : ICommandQueryDispatcher
    {
        public CommandQueryDispatcher(IMediator Mediator)
        {
            this.Mediator = Mediator;
        }

        public IMediator Mediator { get; }

        public async Task<bool> ExecuteCommand<T>(T Command) where T : ICommand
        {
            return await Mediator.Send(Command);
        }

        public async Task<T> ExecuteQuery<T>(IRequest<T> Query)
        {
            return await Mediator.Send(Query);
        }
    }
}
