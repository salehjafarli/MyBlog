using AutoMapper;
using MyBlog.Application.ViewModels;
using MyBlog.Domain.Commands.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.MapProfiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<AddNewArticleVM,CreateArticleCommand>();
            CreateMap<UpdateArticleVM, UpdateArticleCommand>();
            CreateMap<RemoveArticleVM, RemoveArticleCommand>();
        }
    }
}
