using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Feauture.RecentBlog.Models;
using Sitecore.Foundation.Extension.Extension;

namespace Sitecore.Feauture.RecentBlog.Repository
{
    public class RecentBlogRepository
    {
        public List<RecentBlogModel> GetRecentBlogSlider(Item item)
        {
            List<RecentBlogModel> RecentBlogs = new List<RecentBlogModel>();
            if (item != null)
            {
                foreach (var BlogItem in item.GetChildren().ToList())
                {
                    LinkField bloglink = BlogItem.Fields[Template.RecentBlog.Fields.BlogLink];
                    RecentBlogModel blog = new RecentBlogModel()
                    {
                        BlogImage = BlogItem.GetImageUrl(Template.RecentBlog.Fields.BlogImage),
                        BlogTitle = BlogItem.Fields[Template.RecentBlog.Fields.BlogTitle].Value,
                        BlogPublishedDate = BlogItem.GetDate(Template.RecentBlog.Fields.BlogPublishedDate),
                        BolgLink = FieldExtension.GetGeneralLink(bloglink),
                        BolgNews = BlogItem.Fields[Template.RecentBlog.Fields.BlogDetails].Value
                    };
                    RecentBlogs.Add(blog);
                }
            }

            return RecentBlogs;
        }
    }
}