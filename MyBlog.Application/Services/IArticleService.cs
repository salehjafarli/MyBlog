using MyBlog.Application.Responses;
using MyBlog.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Services
{
    public interface IArticleService
    {
        public Task<bool> CreateArticle(AddNewArticleVM vmodel);
        public Task<bool> UpdateArticle(UpdateArticleVM vmodel);
        public Task<bool> DeleteArticle(RemoveArticleVM vmodel);
        public Task<ArticleResponse> GetArticle(int id);
        public Task<ICollection<ArticleResponse>> GetArticle();
    }
}
