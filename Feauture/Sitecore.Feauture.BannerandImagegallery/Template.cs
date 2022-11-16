using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feauture.BannerandImagegallery
{
    public class Template
    {
        public struct ImageGallery
        {
            public static readonly ID ImageTemplateId = new ID("{1BF3B1E0-080B-450F-BCAE-9BCD6168B659}");
            public struct Field
            {
                public static readonly ID Image = new ID("{2C29BC00-1B48-4417-B036-188EFB7D9C30}");
                public static readonly ID ImageBackgroundLink = new ID("{2DDAAB6E-E480-47E2-B06A-70EC4FEC2D0D}");
                public static readonly ID ImagesList = new ID("{D1B92804-023D-4119-A240-6BEBA7A0C056}");
            }
        }
        public struct ExperienceBanner
        {
            public static readonly ID ExperienceBannerTemplateId = new ID("{E6BFCAF5-8614-49D6-A05A-CA79D904E767}");
            public struct Field
            {
                public static readonly ID ExperienceBannerTitle = new ID("{1915B861-F444-476C-8A45-DFBD49AF7C6B}");
            }
        }
        public struct Title
        {
            public static readonly ID TitleTemplateId = new ID("{11FC0EEF-DCBA-46CC-9DC4-F0A792CDA703}");
            public struct Field
            {
                public static readonly ID SmallTitle = new ID("{C0B9E27F-24B2-4C18-BD0C-F993C44CCAD5}");
                public static readonly ID Title = new ID("{F156ED96-0D91-42EA-9D7F-F4FD73572F90}");
            }
        }
    }
}