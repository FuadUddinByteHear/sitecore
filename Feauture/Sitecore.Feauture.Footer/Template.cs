using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feauture.Footer
{
    public class Template
    {
        public struct Footer
        {
            public static readonly ID FooterTemplateId = new ID("{7E45D52F-CEA6-44C4-A907-35602041DD4A}");

            public struct Field
            {
                public static readonly ID RightSideContentTitle = new ID("{C8E52981-1139-46B7-885F-5ABCEFC340F1}");
                public static readonly ID RightSideContentDescription = new ID("{E4A37D04-F331-455E-A4EC-E2A520C03AE7}");
                public static readonly ID FacebookUrl = new ID("{50BFA314-A2DF-4048-A54A-3FB9517DB1D3}");
                public static readonly ID TwitterUrl = new ID("{856C2D71-4B0E-4637-BD45-A51C92C59FB1}");
                public static readonly ID InstagramUrl = new ID("{10C89400-07CA-4F76-B101-DA14A1E8DE02}");
                public static readonly ID UsefulLinkTitle = new ID("{ED01A48C-F3C8-4E8E-895B-E5125FCB7592}");
                public static readonly ID UsefulLinkList = new ID("{18C9D25E-6921-4FC3-8F55-8ECF5FC1C6CD}");
                public static readonly ID PrivacyTitle = new ID("{02852087-E3E2-4C85-A5EB-38CECDA368F9}");
                public static readonly ID PrivacyLinkList = new ID("{6C777B2E-1852-4B09-B499-C9691A2D729B}");
                public static readonly ID ContactInformationTitle = new ID("{8E4825AA-F4BE-4905-A231-2B7BD600F617}");
                public static readonly ID Address = new ID("{7397A7FF-BBBC-41B5-9B21-AF26D89A0955}");
                public static readonly ID PhoneNumber = new ID("{54BE3867-540F-4DDA-A529-90472ABBD0B4}");
                public static readonly ID EmailAddress = new ID("{7FE40A72-CEC2-4E9E-804E-74CE557DB508}");
                public static readonly ID CopyRight = new ID("{FFCF5200-4432-4848-AF9D-A659A16B886C}");
                public static readonly ID MenuName = new ID("{2111FED6-9D12-4918-B133-6B1225E57644}");
            }
        }

    }
}