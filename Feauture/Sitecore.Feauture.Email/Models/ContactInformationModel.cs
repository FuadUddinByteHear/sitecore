using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feauture.Email.Models
{
    public class ContactInformationModel
    {
        public string ContentTitle { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyWebsite { get; set; }
        public string GoogleMap { get; set; }
    }
}