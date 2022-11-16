using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Feauture.Testimonial.Repository;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Feauture.Testimonial.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        public ActionResult Testimonial()
        {
            var DataSource = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var Data = Sitecore.Context.Database.GetItem(DataSource);
            TestimonialRepositoy repository = new TestimonialRepositoy();
            var model = repository.GetAllTestimonial(Data);
            return View("~/Views/Testimonial/Testimonial.cshtml", model);
        }
    }
}