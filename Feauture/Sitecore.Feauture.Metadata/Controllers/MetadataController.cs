using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Feauture.Metadata.Repository;

namespace Sitecore.Feauture.Metadata.Controllers
{
    public class MetadataController : Controller
    {
        // GET: Metadata
        public ActionResult MetaData()
        {
            var model = new MetadataRepository().GetMetaData();
            return View("~/Views/MetaData/MetaData.cshtml", model);
        }
    }
}