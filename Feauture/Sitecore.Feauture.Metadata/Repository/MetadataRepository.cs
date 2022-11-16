using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Foundation.Common;
using Sitecore.Foundation.Common.Models;
using Sitecore.Foundation.Extension.Extension;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Feauture.Metadata.Repository
{
    public class MetadataRepository
    {
        public BasePageModel GetMetaData()
        {
            BasePageModel metadata = new BasePageModel();
            var item= RenderingContext.Current?.Rendering?.Item;
            if (item != null)
            {
                metadata.PageTitle = item.Fields[BasePage.BasePageTemplate.Field.PageTitle].Value;
                metadata.MetaTitle = item.Fields[BasePage.BasePageTemplate.Field.MetaDataTitle].Value;
                metadata.MetaDescription = item.Fields[BasePage.BasePageTemplate.Field.MetaDetails].Value;
                metadata.MetaKeyword = item.Fields[BasePage.BasePageTemplate.Field.MetaKeyWord].Value;
                metadata.MetaRobots = item.Fields[BasePage.BasePageTemplate.Field.MetaRobots].Value;
                metadata.CanonicalUrl = item.GetGeneralLink(BasePage.BasePageTemplate.Field.CornicalUrl);
            }

            return metadata;
        }
    }
}