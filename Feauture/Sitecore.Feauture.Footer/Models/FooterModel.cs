using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feauture.Footer.Models
{
    public class FooterModel
    {
        public string RightSideContentTitle { get; set; }
        public string RightSideContentDescription { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string Copyright { get; set; }
        public UsefulLink usefulLink { get; set; }
        public Privacy Privacy { get; set; }
        public ContactInformation ContactInformation { get; set; }
    }

    public class UsefulLink
    {
        public string UsefulLinkTitle { get; set; }
        public List<UsefulLinkMenu> UsefulMenuList { get; set; }
    }

    public class UsefulLinkMenu
    {
        public string UsefulMenuName { get; set; }
        public string UsefulMenuLink { get; set; }
    }
    public class Privacy
    {
        public string PrivacyTitle { get; set; }
        public List<PrivacyMenu> PrivacyMenuList { get; set; }
    }

    public class PrivacyMenu
    {
        public string PrivacyMenuName { get; set; }
        public string PrivacyMenuLink{ get; set; }
    }

    public class ContactInformation
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string PhoneNumber{ get; set; }
        public string EmailAddress { get; set; }
    }
}