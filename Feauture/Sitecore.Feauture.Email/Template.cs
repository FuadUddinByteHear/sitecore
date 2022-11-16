using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feauture.Email
{
    public class Template
    {
        public struct ContactInformation
        {
            public static readonly ID ContactInformationTemplateId = new ID("{44C7C205-E5E5-4F69-ACDA-C6FB31D220CA}");
            public struct Field
            {
                public static readonly ID ContactInformationTitle = new ID("{E053920A-CFA9-49E9-AAA4-FF568E39DFB8}");
                public static readonly ID CompanyAddress = new ID("{52D88D3E-B850-472D-969D-9187B2A74371}");
                public static readonly ID CompanyNumber = new ID("{FA08DC9A-EDA4-4AA1-BFA7-35E3121E914A}");
                public static readonly ID CompanyEmail = new ID("{A504629D-ED8C-4D33-871F-D7753B5A1480}");
                public static readonly ID CompanyWebsite = new ID("{A42F576E-ECC9-4DD1-8284-61E407CB212D}");
            }
        }
        public struct Subscription
        {
            public static readonly ID SubscriptionTemplateId = new ID("{AA50B100-3DB7-4904-A74B-7CDB9B658790}");
            public struct Field
            {
                public static readonly ID SubscriptioTitle = new ID("{C9B4E8A5-4B79-4AAC-8D54-407989F0EEE6}");
                public static readonly ID SubscriptioSubtitle = new ID("{06A1853F-FA42-4676-B121-9E58BA3AFA42}");
            }
        }
    }
}