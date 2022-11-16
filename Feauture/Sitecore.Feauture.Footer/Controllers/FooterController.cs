using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Feauture.Footer.Repository;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Feauture.Footer.Controllers
{
    public class FooterController : Controller
    {
        // GET: Footer
        public ActionResult Footer()
        {
            var DataSourceId = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var data = Sitecore.Context.Database.GetItem(DataSourceId);
            FooterRepository repository = new FooterRepository();
            var model = repository.GetFooter(data);
            return View("~/Views/Footer/Footer.cshtml", model);
        }
    }
}