using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Feauture.Header.Models;
using Sitecore.Web.UI.WebControls.Presentation;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Data.Templates;
using Sitecore.Feauture.Header.Settings;
using Sitecore.Foundation.Common;
using Sitecore.Foundation.Common.Models;
using Sitecore.Foundation.Extension.Extension;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using Item = Sitecore.Data.Items.Item;

namespace Sitecore.Feauture.Header.Repository
{
    public class HeaderRepository
    {
        public HeaderModel GetHeader(Item item)
        {
            HeaderModel header = new HeaderModel();
            List<HeaderMenuList> HeaderMenuList = new List<HeaderMenuList>();
            if (item != null)
            {
                header.DesktopLogo = item.Fields[BasePage.HeaderLogo.Field.DesktopLogo].Value;
                header.MobileLogo= item.Fields[BasePage.HeaderLogo.Field.MobileLogo].Value;
                var homenode= Sitecore.Context.Database.GetItem(ApplicationStartingPage.StartItem);
                var homeitem = PopulateModel(homenode);
                if (homeitem.ShowMenu == "1")
                {
                    HeaderMenuList.Add(homeitem);
                }

                if (homenode.HasChildren)
                {
                    foreach (var data in homenode.GetChildren().ToList())
                    {
                        var page = PopulateModel(data);
                        if (page.ShowMenu=="1" || page.ShowAsButton=="1")
                        {
                            HeaderMenuList.Add(page);
                        }
                    }
                }
                header.HeaderMenuList = HeaderMenuList;
            }
            return header;
        }

        public HeaderMenuList PopulateModel(Item item)
        {
            var check = item[BasePage.BasePageTemplate.Field.ShowAsButton];
            if (check=="1")
            {
                LinkField buttonlink = item.Fields[BasePage.BasePageTemplate.Field.ShowAsButtonLink];
                HeaderMenuList page = new HeaderMenuList()
                {
                    MenuName = item[BasePage.BasePageTemplate.Field.ShowAsButtonName],
                    MenuLink = FieldExtension.GetGeneralLink(buttonlink),
                    ShowMenu = item[BasePage.NavigationMenu.Field.ShowNavigation],
                    ShowAsButton = item[BasePage.BasePageTemplate.Field.ShowAsButton]
                };
                return page;
            }
            else
            {
                HeaderMenuList page = new HeaderMenuList()
                {
                    MenuName = item[BasePage.NavigationMenu.Field.NavigationName],
                    MenuLink = LinkManager.GetItemUrl(item),
                    ShowMenu = item[BasePage.NavigationMenu.Field.ShowNavigation],
                    ShowAsButton = item[BasePage.BasePageTemplate.Field.ShowAsButton],
                    ActiveMenu = PageContext.Current.Item.ID == item.ID ? "active" : string.Empty
                };
                return page;
            }
        }
    }
}