using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Feauture.Email.Models;
using Sitecore.Foundation.Extension.Extension;

namespace Sitecore.Feauture.Email.Repository
{
    public class ContactRepository
    {
        public ContactInformationModel GetAllContactInformation(Item item)
        {
            ContactInformationModel contactinformation = new ContactInformationModel();
            if (item != null)
            {
                contactinformation.ContentTitle = item.Fields[Template.ContactInformation.Field.ContactInformationTitle].Value;
                contactinformation.CompanyAddress = item.Fields[Template.ContactInformation.Field.CompanyAddress].Value;
                contactinformation.CompanyNumber = item.Fields[Template.ContactInformation.Field.CompanyNumber].Value;
                contactinformation.CompanyEmail = item.Fields[Template.ContactInformation.Field.CompanyEmail].Value;
                LinkField website = item.Fields[Template.ContactInformation.Field.CompanyWebsite];
                contactinformation.CompanyWebsite = FieldExtension.GetGeneralLink(website);
                contactinformation.GoogleMap= item.Fields[Template.ContactInformation.Field.GoogleMap].Value;

            }
            return contactinformation;
        }
    }
}