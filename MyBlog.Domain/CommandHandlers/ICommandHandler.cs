using MediatR;
using MyBlog.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.CommandHandlers
{
    public interface ICommandHandler<T> : IRequestHandler<T,bool> where T : ICommand
    {

    }
}
