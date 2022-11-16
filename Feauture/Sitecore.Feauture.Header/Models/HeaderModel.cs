using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feauture.Header.Models
{
    public class HeaderModel
    {
        public string DesktopLogo { get; set; }
        public string MobileLogo { get; set; }
        public List<HeaderMenuList>HeaderMenuList { get; set; }

    }

    public class HeaderMenuList
    {
        public string MenuName { get; set; }
        public string MenuLink { get; set; }
        public string ShowMenu { get; set; }
        public string ShowAsButton { get; set; }
        public string ActiveMenu { get; set; }
    }
}