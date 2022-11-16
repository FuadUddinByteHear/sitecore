using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feauture.RecentBlog
{
    public class Template
    {
        public struct RecentBlog
        {
            public static readonly ID RecentBlogTemplateId = new ID("{84FC2151-9670-45C4-AF8B-1AEE7F74738B}");
            public struct Fields
            {
                public static readonly ID BlogImage = new ID("{B5FCCF94-9FD3-47F4-8177-912AE3360431}");
                public static readonly ID BlogTitle = new ID("{85FD2B6A-88B5-4185-BDF1-76C1EF62C54E}");
                public static readonly ID BlogDetails = new ID("{9EC19255-D42A-43AC-9DE3-284E06C38E7D}");
                public static readonly ID BlogPublishedDate = new ID("{8B2258C6-6F26-4C5F-9459-4B6DE2FD5DBC}");
                public static readonly ID BlogLink= new ID("{76B3049B-9FE9-4D01-B2E5-F35D3D54C1B7}");
            }
        }
    }
}