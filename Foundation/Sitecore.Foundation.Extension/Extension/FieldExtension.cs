using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Resources.Media;

namespace Sitecore.Foundation.Extension.Extension
{
    public static class FieldExtension
    {
        public static string GetImageUrl(this Item item, ID itemid)
        {
            var ImageUrl = "";
            if (item.Fields[itemid] != null)
            {
                ImageField Image = item.Fields[itemid];
                ImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(Image.MediaItem);
            }
            return ImageUrl;
        }

        public static string GetGeneralLink(this LinkField item)
        {
            var LinkUrl = "";
            if (item != null)
            {
                switch (item.LinkType.ToLower())
                {
                    case "internal":
                        // Use LinkMananger for internal links, if link is not empty
                        if (item.TargetItem != null )
                        {
                            LinkUrl = LinkManager.GetItemUrl(item.TargetItem);
                        }
                        return LinkUrl;
                    case "external":
                        // Just return external links 
                        LinkUrl= item.Url;
                        return LinkUrl;
                    case "anchor":
                        // Prefix anchor link with # if link if not empty
                        if (string.IsNullOrEmpty(item.Anchor))
                        {
                            LinkUrl = "#" + item.Anchor;
                        }
                        return LinkUrl;
                    case "mailto":
                        // Just return mailto link
                        LinkUrl = item.Url;
                        return LinkUrl;
                    case "javascript":
                        // Just return javascript
                        LinkUrl = item.Url;
                        return LinkUrl;
                    default:
                        LinkUrl = item.Url;
                        return LinkUrl;
                }
            }
            return LinkUrl;
        }

        public static string GetGeneralLinkTitle(this Item item, ID itemid)
        {
            var LinkUrlTitle = "";
            if (item.Fields[itemid] != null)
            {
                var link = ((LinkField)item.Fields[itemid]);
                LinkUrlTitle = link.Title;
            }

            return LinkUrlTitle;
        }

        public static bool FindFieldValue(this Item item, ID itemid)
        {
            bool hasvalue = false;
            if (item.Fields[itemid] != null)
            {
                hasvalue = true;
            }

            return hasvalue;
        }

        public static string GetDate(this Item item, ID itemid)
        {
            var Date = "";
            if (item.Fields[itemid] != null)
            {
                DateField datefield = item.Fields[itemid];
                Date = datefield.DateTime.ToString();
            }

            return Date;
        }
    }
}