using HPlusSportTDD.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSportTDD.Web.Controllers
{
    public class ShopController : Controller
    {
        private List<Article> _articles = new List<Article>() {
            new Article() { Id=1, Name="Red T-Shirt", Price=9.99},
            new Article() { Id=2, Name="Blue T-Shirt", Price=11.99},
            new Article() { Id=3, Name="Green Windbreaker", Price=99.99}
        };

        public IActionResult Index(string query)
        {
            var model = _articles;
            if (!string.IsNullOrWhiteSpace(query))
            {
                model = _articles.Where(a => a.Name.ToLower().Contains(query.ToLower())).ToList();
            }

            return View(model);
        }

    }
}
