using MediatR;
using MyBlog.Domain.Queries;
using MyBlog.Domain.Queries.Article;
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
                                       IRequestHandler<QueryArticleByCategory, ICollection<T>>,
                                       IRequestHandler<QueryRecentArticles, ICollection<T>>,
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

        public async Task<T> Handle(QueryById<T> request, CancellationToken cancellationToken)
        {
            return await Repo.GetById(request.Id);
        }

        public async Task<ICollection<T>> Handle(QueryArticleByCategory request, CancellationToken cancellationToken)
        {
            return await Repo.GetByCategory(request.Category);
        }

        public async Task<ICollection<T>> Handle(QueryRecentArticles request, CancellationToken cancellationToken)
        {
            return await Repo.GetMostRecent(request.Amount);
        }
    }
}
