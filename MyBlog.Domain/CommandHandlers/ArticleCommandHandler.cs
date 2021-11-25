using MyBlog.Domain.Commands.Article;
using MyBlog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBlog.Domain.CommandHandlers
{
    public class ArticleCommandHandler : ICommandHandler<CreateArticleCommand>,
                                         ICommandHandler<UpdateArticleCommand>,
                                         ICommandHandler<RemoveArticleCommand>
    {

        public ArticleCommandHandler(IArticleRepository Repo)
        {
            this.Repo = Repo;
        }

        public IArticleRepository Repo { get; }

        public Task<bool> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Handle(RemoveArticleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
