using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Foundation.Common
{
    public class BasePage
    {
        public struct BasePageTemplate
        {
            public static readonly ID BasePageTemplateID = new ID("{DEB9C409-DAE0-46E9-8815-01E376A88685}");
            public struct Field
            {
                public static readonly ID PageTitle = new ID("{F3BE5F34-1C8B-4BA6-91A1-1863956E19C6}");
                public static readonly ID PageName = new ID("{C9FA9029-1C1E-49D9-882B-B58C9B92B0E2}");
                public static readonly ID PageImage = new ID("{584C9498-E079-4C8D-9550-BDC637C4E67B}");
                public static readonly ID ShowAsButton = new ID("{ADE16EA5-64D2-4C6D-A3BA-1771AE8F5867}");
                public static readonly ID ShowAsButtonName = new ID("{D8759A82-9C11-45A5-8796-294A334EF846}");
                public static readonly ID ShowAsButtonLink = new ID("{C3734446-18F8-457E-A5C2-6DE44D1E74BF}");
                public static readonly ID MetaDataTitle = new ID("{51FA0C2B-76CD-4B28-905F-078C83109CFF}");
                public static readonly ID MetaDetails = new ID("{4CAEB7F3-88F4-48D8-9476-258F618AB092}");
                public static readonly ID MetaKeyWord = new ID("{ADE16EA5-64D2-4C6D-A3BA-1771AE8F5867}");
                public static readonly ID MetaRobots = new ID("{D8759A82-9C11-45A5-8796-294A334EF846}");
                public static readonly ID CornicalUrl = new ID("{C3734446-18F8-457E-A5C2-6DE44D1E74BF}");
            }
        }
        public struct NavigationMenu
        {
            public static readonly ID NavigationTemplateID = new ID("{BAAD83F0-7947-4AEF-84B3-27D40459497B}");
            public struct Field
            {
                public static readonly ID NavigationName = new ID("{2111FED6-9D12-4918-B133-6B1225E57644}");
                public static readonly ID ShowNavigation = new ID("{DE774F8D-D47C-4827-8055-43119F35C1CB}");
                public static readonly ID ShowSubMenu = new ID("{8D5C6160-3509-42B0-9BEF-8FCAB6D73685}");
            }
        }
        public struct Annoucement
        {
            public static readonly ID AnnoucementTemplateID = new ID("{220BBB2B-04AB-491D-8084-92FFA5F791CC}");
            public struct Field
            {
                public static readonly ID AnnoucementTitle = new ID("{78660B5A-205D-4339-940F-A984E53D138C}");
                public static readonly ID AnnoucementDescription = new ID("{02237A39-C8C0-46C5-BC76-0B6186FB5B17}");
                public static readonly ID AvailableEnds = new ID("{4AE7670A-C1EE-4ABF-830B-C43C34D45AC6}");
            }
        }
        public struct HeaderLogo
        {
            public static readonly ID HeaderLogoTemplateId = new ID("{20749FA8-AE9F-4E41-ABF2-9AEBF07F61D3}");

            public struct Field
            {
                public static readonly ID DesktopLogo = new ID("{C7D48125-B541-404F-BE37-0A56C290B9F9}");
                public static readonly ID MobileLogo = new ID("{2E421C22-65A1-4269-BFF6-2268B50FE612}");
            }
        }
    }
}