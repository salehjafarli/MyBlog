using AutoMapper;
using MyBlog.Application.Responses;
using MyBlog.Application.ViewModels;
using MyBlog.Domain.Commands.Article;
using MyBlog.Domain.Entites;
using MyBlog.Domain.ValueObjects;
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
            CreateMap<Article,ArticleResponse>();
            CreateMap<Section, SectionResponse>();
        }
    }
}
