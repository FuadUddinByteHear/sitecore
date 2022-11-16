using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feauture.Header.Settings
{
    public class ApplicationStartingPage
    {
        public static string StartItem { get { return HttpUtility.HtmlDecode(Sitecore.Configuration.Settings.GetSetting("EventtalkStartItem")); } }
    }
}