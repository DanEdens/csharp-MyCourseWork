using HPlusSportTDD.API.Controllers;
using HPlusSportTDD.Core;
using HPlusSportTDD.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace HPlusSportTDD.Web
{
    public class ApiTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnAllArticles()
        {
            var controller = new ArticlesController();

            var result = controller.GetAll();

            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public void ShouldReturnSingleArticle()
        {
            var controller = new ArticlesController();

            var result = controller.GetSingle(3);

            Assert.IsInstanceOf(typeof(OkObjectResult), result);
        }

        [Test]
        public void ShouldReturn404OnMissingArticle()
        {
            var controller = new ArticlesController();

            var result = controller.GetSingle(42);

            Assert.AreEqual((result as StatusCodeResult)?.StatusCode, 404);
        }



    }
}