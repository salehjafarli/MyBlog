using MediatR;
using MyBlog.Domain.Queries;
using MyBlog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBlog.Domain.QueryHandlers.Article
{
    using T = Entites.Article;
    public class ArticleQueryHandler : IRequestHandler<QueryAll<T>, ICollection<T>>,
                                       IRequestHandler<QueryById<T>,T>
    {
        public ArticleQueryHandler(IArticleRepository Repo)
        {
            this.Repo = Repo;
        }

        public IArticleRepository Repo { get; }

        public async Task<ICollection<T>> Handle(QueryAll<T> request, CancellationToken cancellationToken)
        {
            return (await Repo.Get()).ToList();
        }

        public Task<T> Handle(QueryById<T> request, CancellationToken cancellationToken)
        {
            return Repo.GetById(request.Id);
        }
    }
}
