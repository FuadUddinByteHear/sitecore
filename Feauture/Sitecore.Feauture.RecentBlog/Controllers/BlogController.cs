using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Feauture.RecentBlog.Repository;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Feauture.RecentBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult BlogHome()
        {
            var DataSourceId = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var Data = Sitecore.Context.Database.GetItem(DataSourceId);
            RecentBlogRepository repository = new RecentBlogRepository();
            var model = repository.GetRecentBlogSlider(Data);
            return View("~/Views/Blog/BlogHome.cshtml", model);
        }
        public ActionResult Blog()
        {
            var DataSourceId = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var Data = Sitecore.Context.Database.GetItem(DataSourceId);
            RecentBlogRepository repository = new RecentBlogRepository();
            var model = repository.GetRecentBlogSlider(Data);
            return View("~/Views/Blog/Blog.cshtml", model);
        }
    }
}