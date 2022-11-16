using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feauture.EventSchuduleandticketpricing
{
    public class Template
    {
        public struct pricing
        {
            public static readonly ID PricingTemplateId = new ID("{F58A8F2D-7855-4753-B929-8AC392B5B99F}");
            public struct Field
            {
                public static readonly ID PricingTitle = new ID("{81AC5DF1-9736-4090-8601-86C35EB31F9E}");
                public static readonly ID Price = new ID("{AA451ACB-F2BC-4165-93BB-55FF64D6856D}");
                public static readonly ID PricingDetails = new ID("{C5A4ACD2-FF5D-4E45-8A5C-31877766921B}");
                public static readonly ID FeaturesTitle = new ID("{E863A9E5-A077-4B92-B8AD-A21039757186}");
                public static readonly ID ButtonLink = new ID("{2C29BC00-1B48-4417-B036-188EFB7D9C30}");
                public static readonly ID FeaturesList = new ID("{ADFFA3F4-DC0A-485C-9E1C-4E621D767263}");
            }
        }
        public struct Event
        {
            public static readonly ID EventTemplateId = new ID("{06BE05E5-3CB6-43F8-B258-52AD27C18993}");
            public struct Field
            {
                public static readonly ID EventTitle = new ID("{CC21D0EB-13AF-4CE4-90F7-7FEF464CDFDB}");
                public static readonly ID EventDescription = new ID("{9A1ABF6C-19D7-4D53-8AE1-4FAC210F251C}");
                public static readonly ID SpeakerImage = new ID("{409A0E3B-0484-4748-A823-F5A7BDF1DEC0}");
                public static readonly ID SpeakerName = new ID("{3EB9C77A-9568-40D4-9AF1-64766B18D89A}");
                public static readonly ID SpeakerOccupation = new ID("{8FA225D6-B705-4223-92E8-87736DC8DE34}");
                public static readonly ID StartTime = new ID("{52B89AAD-E56D-4488-A911-8D85DCBCB1B6}");
                public static readonly ID EndTime = new ID("{CFD82216-6FED-45BA-B693-8C8845C8716F}");
                public static readonly ID PublishedDate = new ID("{FC5426E9-3791-4ED6-877D-E873C7E12703}");
                public static readonly ID TabIdName = new ID("{18F2849A-09CF-4205-AD8C-18E9635392C6}");
                public static readonly ID TargetedTab = new ID("{4D589034-FAD4-4954-A689-9A5881348AF0}");
            }
        }
    }
}