using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Feauture.Footer.Models;
using Sitecore.Foundation.Extension.Extension;
using Sitecore.Links;

namespace Sitecore.Feauture.Footer.Repository
{
    public class FooterRepository
    {
        public FooterModel GetFooter(Item item)
        {
            FooterModel footer = new FooterModel();
            List<UsefulLinkMenu> UsefulMenuList = new List<UsefulLinkMenu>();
            List<PrivacyMenu> PrivacyMenuList = new List<PrivacyMenu>();
            if (item != null)
            {
                footer.RightSideContentTitle = item.Fields[Template.Footer.Field.RightSideContentTitle].Value;
                footer.RightSideContentDescription =
                    item.Fields[Template.Footer.Field.RightSideContentDescription].Value;
                LinkField facebookurl = item.Fields[Template.Footer.Field.FacebookUrl];
                LinkField twitterkurl = item.Fields[Template.Footer.Field.TwitterUrl];
                LinkField intagramurl = item.Fields[Template.Footer.Field.InstagramUrl];
                footer.FacebookLink = FieldExtension.GetGeneralLink(facebookurl);
                footer.TwitterLink = FieldExtension.GetGeneralLink(twitterkurl);
                footer.InstagramLink = FieldExtension.GetGeneralLink(intagramurl);
                footer.Copyright = item.Fields[Template.Footer.Field.CopyRight].Value;
                footer.ContactInformation.Address = item.Fields[Template.Footer.Field.Address].Value;
                footer.ContactInformation.PhoneNumber = item.Fields[Template.Footer.Field.PhoneNumber].Value;
                footer.ContactInformation.EmailAddress = item.Fields[Template.Footer.Field.EmailAddress].Value;
                footer.usefulLink.UsefulLinkTitle = item.Fields[Template.Footer.Field.UsefulLinkTitle].Value;
                footer.ContactInformation.Title = item.Fields[Template.Footer.Field.ContactInformationTitle].Value;
                footer.Privacy.PrivacyTitle = item.Fields[Template.Footer.Field.PrivacyTitle].Value;
                MultilistField UsefulLinksList = item.Fields[Template.Footer.Field.UsefulLinkList];
                Item[] usefullinklist = UsefulLinksList.GetItems();
                if (usefullinklist != null)
                {
                    foreach (var useful in usefullinklist)
                    {
                        UsefulLinkMenu usefullink = new UsefulLinkMenu()
                        {
                            UsefulMenuName = useful.Fields[Template.Footer.Field.MenuName].Value,
                            UsefulMenuLink = LinkManager.GetItemUrl(useful)
                        };
                        UsefulMenuList.Add(usefullink);
                    }
                }
                MultilistField PrivacyMenuLinkList = item.Fields[Template.Footer.Field.PrivacyLinkList];
                Item[] privacylinks = PrivacyMenuLinkList.GetItems();
                if (privacylinks != null)
                {
                    foreach (var privacy in privacylinks)
                    {
                        PrivacyMenu privacymenu = new PrivacyMenu
                        {
                            PrivacyMenuName = privacy.Fields[Template.Footer.Field.MenuName].Value,
                            PrivacyMenuLink = LinkManager.GetItemUrl(privacy)
                        };
                        PrivacyMenuList.Add(privacymenu);
                    }
                }
            }

            footer.Privacy.PrivacyMenuList = PrivacyMenuList;
            footer.usefulLink.UsefulMenuList = UsefulMenuList;
            return footer;
        }
    }
}