using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Application.Attributes;
using MyBlog.Application.Services;
using MyBlog.Application.ViewModels;
using MyBlog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class ArticleController : ControllerBase
    {
        public ArticleController(IArticleService ArticleService)
        {
            this.ArticleService = ArticleService;
        }
        public IArticleService ArticleService { get; }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var res = await ArticleService.GetArticle(id);
            return res is null ? NotFound() : Ok(res);
        }
        [HttpGet]
        [Route("GetByCategory/{category}")]
        public async Task<IActionResult> Get(string category)
        {
            var res = await ArticleService.GetArticle(category);
            return res is null ? NotFound() : Ok(res);
        }
        [HttpGet]
        [Route("GetRecentArticles/{amount}")]
        public async Task<IActionResult> GetRecentArticles(int amount = 4)
        {
            var res = await ArticleService.GetRecentArticles(amount);
            return res is null ? NotFound() : Ok(res);
        }
        [HttpGet]
        [Route("FeaturedArticle")]
        public async Task<IActionResult> GetFeaturedArticle()
        {
            var res = await ArticleService.GetFeaturedArticle();
            return res is null ? NotFound() : Ok(res);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = await ArticleService.GetArticle();
            return res is null ? NotFound() : Ok(res);
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddNewArticleVM VModel)
        {
            var res = await ArticleService.CreateArticle(VModel);
            return res ? Ok() : NotFound(); 
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateArticleVM VModel)
        {
            var res = await ArticleService.UpdateArticle(VModel);
            return res ? Ok() : NotFound();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(RemoveArticleVM VModel)
        {
            var res = await ArticleService.DeleteArticle(VModel);
            return res ? Ok() : NotFound();
        }

    }
}
