using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Feauture.Speaker.Repositorty;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Feauture.Speaker.Controllers
{
    public class SpeakerController : Controller
    {
        // GET: Speaker
        public ActionResult SpeakerSlider()
        {
            var datasourceid = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var datasource = Sitecore.Context.Database.GetItem(datasourceid);
            SpeakerRepository data = new SpeakerRepository();
            var model = data.GetAllSliderSpeaker(datasource);
            return View("~/Views/Speaker/SpeakerSlider.cshtml", model);
        }
        public ActionResult SpeakerList()
        {
            var datasourceid = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var datasource = Sitecore.Context.Database.GetItem(datasourceid);
            SpeakerRepository data = new SpeakerRepository();
            var model = data.GetAllSpeaker(datasource);
            return View("~/Views/Speaker/SpeakerList.cshtml", model);
        }
    }
}