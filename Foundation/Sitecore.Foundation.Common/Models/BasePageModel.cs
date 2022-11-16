using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Foundation.Common.Models
{
    public class BasePageModel
    {
        public string NavigationName { get; set; }
        public string ShowMainMenu { get; set; }
        public string ShowSubMenu { get; set; }
        public string PageTitle { get; set; }
        public string PageName { get; set; }
        public string PageImage { get; set; }
        public string AnnoucementTitle { get; set; }
        public string AnnoucementSubtitle { get; set; }
        public string AnnoucementDescription { get; set; }
        public string AvailableEnd { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaRobots { get; set; }
        public string CanonicalUrl { get; set; }
        public string PageUrl { get; set; }
        public ID ParentId { get; set; }
       
        public ID ItemId { get; set; }
     
        public bool HasChild { get; set; }
      
    }
}