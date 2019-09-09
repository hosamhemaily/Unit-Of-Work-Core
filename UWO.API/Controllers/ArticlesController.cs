﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UOW.Model;
using UOW.Sevice;

namespace UWO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IArticleService _articleService;
        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET api/values/5
        [HttpGet()]
        public List<ArticleModel> Get()
        {
            var result = _articleService.Get();
            return result.ToList();
        }

        // GET api/values/5
        [HttpPost("[action]")]
        public async Task<int> Add()
        {
            await _articleService.AddArticle(new ArticleModel { Name="test"});
            return 1;
        }

        // GET api/values/5
        [HttpPost("[action]")]
        public async Task<int> AddWithTransaction()
        {
            await _articleService.AddArticleTransaction(new ArticleModel { Name = "test" });
            return 1;
        }

        // GET api/values/5
        [HttpPost("[action]")]
        public async Task<int> AddWithTransactionWithAnotherTable()
        {
            await _articleService.AddArticleTransactionWithAnotherTable(new ArticleModel { Name = "test" });
            return 1;
        }
    }
}