using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODataReferences.Web.Models;
using ODataReferences.Web.Proxies;

namespace ODataReferences.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var blogDataProxy = new BlogDataProxy();

            var fc = blogDataProxy.Posts.First();

            var firstComments = from p in blogDataProxy.Posts
                                where p.Title.Contains("OData")
                                select p;

            var model = new BlogPostsModel
                            {
                                Posts = blogDataProxy.Posts.ToArray()
                            };

            return View(model);
        }

    }
}
