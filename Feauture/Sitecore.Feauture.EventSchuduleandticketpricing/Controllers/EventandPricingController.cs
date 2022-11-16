using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Feauture.EventSchuduleandticketpricing.Repository;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.Authentication;

namespace Sitecore.Feauture.EventSchuduleandticketpricing.Controllers
{
    public class EventandPricingController : Controller
    {
        // GET: EventandPricing
        public ActionResult TicketPricing()
        {
            var DataSourceId = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var DataSource = Sitecore.Context.Database.GetItem(DataSourceId);
            EventandPricingRepository repository = new EventandPricingRepository();
            var model = repository.GetAllPricing(DataSource);
            return View("~/Views/EventandPricing/TicketPricing.cshtml", model);
        }
        public ActionResult EventSchedule()
        {
            var DataSourceId = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var DataSource = Sitecore.Context.Database.GetItem(DataSourceId);
            EventandPricingRepository repository = new EventandPricingRepository();
            var model = repository.GetAllEventDetails(DataSource);
            return View("~/Views/EventandPricing/EventSchedule.cshtml", model);
        }
        
    }
}