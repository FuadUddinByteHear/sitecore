using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feauture.FunFactsandServices
{
    public class Template
    {
        public struct Services
        {
            public static readonly ID ServiceTemplateId = new ID("{DCC76FC5-229A-4EBA-B156-1250313CB9E2}");
            public struct Field
            {
                public static readonly ID Title = new ID("{EDD5B0B7-BDED-4C38-9B90-665BF4481A28}");
                public static readonly ID Subtitle = new ID("{2E493C12-471F-4860-B007-1FD276242BDC}");
                public static readonly ID Icon = new ID("{EB1CB7C4-B7D6-41A3-BDDA-E9C06DF8EA62}");
                public static readonly ID ServiceList = new ID("{E52048B3-E176-4D50-8795-4E0F4338A16F}");
            }
        }
        public struct FunFacts
        {
            public static readonly ID FunFactsTemplateId = new ID("{43464721-B798-4D7F-844B-411F32E35D75}");
            public struct Field
            {
                public static readonly ID FunFactsTitle = new ID("{7F2CC6AC-E360-42DE-B76B-4CDBD6B47A90}");
                public static readonly ID FunFactsSubtitle = new ID("{FF6835E5-8D70-4DFC-87C8-38180E8E00BA}");
                public static readonly ID FunFactsSmallTitle = new ID("{2394EFCC-EA40-4E18-8F83-68895655D432}");
                public static readonly ID FunFactsImage= new ID("{C7E3625C-F8F2-4152-B5E1-B23C3D4ED675}");
                public static readonly ID FunFactsServicesList = new ID("{F0F8269B-696A-4AF0-BC05-11FB8D30C4C7}");
                public static readonly ID ServicesTitle = new ID("{369977BB-1E79-48FA-B8D8-3A193E2738D6}");
                public static readonly ID ServicesIcon = new ID("{510E3FB0-92AD-4580-AF02-4DAF104F7528}");
                public static readonly ID ServicesTotalPeople = new ID("{D07FF983-1F59-40DC-9C04-2BDB1F568D82}");
            }
        }
    }
}