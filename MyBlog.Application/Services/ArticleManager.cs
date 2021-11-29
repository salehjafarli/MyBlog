using AutoMapper;
using MyBlog.Application.Responses;
using MyBlog.Application.ViewModels;
using MyBlog.Domain.CommandDispatchers;
using MyBlog.Domain.Commands;
using MyBlog.Domain.Commands.Article;
using MyBlog.Domain.Entites;
using MyBlog.Domain.Queries;
using MyBlog.Domain.Queries.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Services
{
    public class ArticleManager : IArticleService
    {
        public ArticleManager(ICommandQueryDispatcher CommandQueryDispatcher, IMapper Mapper)
        {
            this.CommandQueryDispatcher = CommandQueryDispatcher;
            this.Mapper = Mapper;
        }

        public ICommandQueryDispatcher CommandQueryDispatcher { get; }
        public IMapper Mapper { get; }

        public async Task<bool> CreateArticle(AddNewArticleVM vmodel)
        {
            var command = Mapper.Map<CreateArticleCommand>(vmodel);
            var res = await CommandQueryDispatcher.ExecuteCommand(command);
            return res;
        }
        public async Task<bool> UpdateArticle(UpdateArticleVM vmodel)
        {
            var command = Mapper.Map<UpdateArticleCommand>(vmodel);
            var res = await CommandQueryDispatcher.ExecuteCommand(command);
            return res;
        }

        public async Task<bool> DeleteArticle(RemoveArticleVM vmodel)
        {
            var command = Mapper.Map<RemoveArticleCommand>(vmodel);
            var res = await CommandQueryDispatcher.ExecuteCommand(command);
            return res;
        }

        public async Task<ArticleResponse> GetArticle(int id)
        {
            var query = new QueryById<Article>(id);
            var res = await CommandQueryDispatcher.ExecuteQuery(query);
            //Replace(res);
            return Mapper.Map<ArticleResponse>(res);
        }

        public async Task<ICollection<ArticleResponse>> GetArticle()
        {
            var query = new QueryAll<Article>();
            var res = await CommandQueryDispatcher.ExecuteQuery(query);
            //foreach (var item in res)
            //{
            //    Replace(item);
            //}
            return Mapper.Map<List<ArticleResponse>>(res);
        }


        public async Task<ICollection<ArticleResponse>> GetArticle(string category)
        {
            var query = new QueryArticleByCategory(category);
            var res = await CommandQueryDispatcher.ExecuteQuery(query);
            return Mapper.Map<List<ArticleResponse>>(res);
        }
    }
}
