using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Feauture.Header.Repository;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Feauture.Header.Controllers
{
    public class HeaderController : Controller
    {
        // GET: Header
        public ActionResult Header()
        {
            var DataSourceId = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var data = Sitecore.Context.Database.GetItem(DataSourceId);
            HeaderRepository repository = new HeaderRepository();
            var model = repository.GetHeader(data);
            return View("~/Views/Header/Header.cshtml", model);
        }
    }
}