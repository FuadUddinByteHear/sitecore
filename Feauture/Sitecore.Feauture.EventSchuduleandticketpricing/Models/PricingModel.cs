using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feauture.EventSchuduleandticketpricing.Models
{
    public class PricingModel
    {
        public string PricingTitle { get; set; }

        public string Price { get; set; }
        public string PricingDetails { get; set; }

        public string ButtonTitle { get; set; }
        public string ButtonLink { get; set; }

        public string FeautureTitle { get; set; }
        public string Feautures { get; set; }
    }
}