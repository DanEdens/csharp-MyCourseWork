using HPlusSportTDD.Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HPlusSportTDD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private static List<Article> _articles = new List<Article>() {
            new Article() { Id=1, Name="Red T-Shirt", Price=9.99},
            new Article() { Id=2, Name="Blue T-Shirt", Price=11.99},
            new Article() { Id=3, Name="Green Windbreaker", Price=99.99}
        };

        [HttpGet]
        public IEnumerable<Article> GetAll()
        {
            return _articles;
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            var article = _articles.Find(a => a.Id == id);
            
            if (article == null)
            {
                return NotFound();
            }

            return Ok(article);
        }
    }
}
