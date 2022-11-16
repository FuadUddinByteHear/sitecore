using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Feauture.EventSchuduleandticketpricing.Models;
using Sitecore.Foundation.Extension.Extension;
using System.Web.Mvc;
namespace Sitecore.Feauture.EventSchuduleandticketpricing.Repository
{
    public class EventandPricingRepository
    {
        public List<PricingModel> GetAllPricing(Item item)
        {
            List<PricingModel> PricingList = new List<PricingModel>();
            if (item != null)
            {
                if (item.HasChildren)
                {
                    foreach (var PriceDetails in item.GetChildren().ToList())
                    {
                        MultilistField feauteritems = PriceDetails.Fields[Template.pricing.Field.FeaturesList];
                        var feautureitemlist = feauteritems.GetItems().ToList();
                        LinkField buttonlink = PriceDetails.Fields[Template.pricing.Field.ButtonLink];
                        PricingModel price = new PricingModel()
                        {
                            PricingTitle = PriceDetails.Fields[Template.pricing.Field.PricingTitle].Value,
                            Price = PriceDetails.Fields[Template.pricing.Field.Price].Value,
                            PricingDetails = PriceDetails.Fields[Template.pricing.Field.PricingDetails].Value,
                            FeautureTitle = PriceDetails.Fields[Template.pricing.Field.FeaturesTitle].Value,
                            ButtonLink = FieldExtension.GetGeneralLink(buttonlink),
                            ButtonTitle = PriceDetails.GetGeneralLinkTitle(Template.pricing.Field.ButtonLink),
                            Feautures = PriceDetails.Fields[Template.pricing.Field.FeaturesList].Value
                        };
                        PricingList.Add(price);
                    }
                }

            }
            return PricingList;
        }
        public EventModel GetAllEventDetails(Item item)
        {
            List<EventDetails> EventDetailsList = new List<EventDetails>();
            List<PublishedDetails> PublisedDetailsList = new List<PublishedDetails>();
            EventModel EventDetails =new EventModel();
            if (item != null)
            {
                if (item.HasChildren)
                {
                    foreach (var EventDetailsItem in item.GetChildren().ToList())
                    {
                        var datevalue = EventDetailsItem.Fields[Template.Event.Field.PublishedDate].Value;
                        if (CheckDateIsValid(datevalue, PublisedDetailsList))
                        {
                            PublishedDetails publisheddetails = new PublishedDetails()
                            {
                                PublishedDate = EventDetailsItem.Fields[Template.Event.Field.PublishedDate].Value,
                                TabIdName = EventDetailsItem.Fields[Template.Event.Field.TabIdName].Value,
                                TargetedTab = EventDetailsItem.Fields[Template.Event.Field.TargetedTab].Value,
                            };
                            PublisedDetailsList.Add(publisheddetails);
                        }
                        EventDetails eventdetails = new EventDetails()
                        {
                            StartingTime = EventDetailsItem.Fields[Template.Event.Field.StartTime].Value,
                            EndingTime = EventDetailsItem.Fields[Template.Event.Field.EndTime].Value,
                            SpeakerImage = EventDetailsItem.GetImageUrl(Template.Event.Field.SpeakerImage),
                            SpeakerName = EventDetailsItem.Fields[Template.Event.Field.SpeakerName].Value,
                            SpeakerOcupation = EventDetailsItem.Fields[Template.Event.Field.SpeakerOccupation].Value,
                            EventTitle = EventDetailsItem.Fields[Template.Event.Field.EventTitle].Value,
                            EventDescription = EventDetailsItem.Fields[Template.Event.Field.EventDescription].Value,
                            PublishedDate= EventDetailsItem.Fields[Template.Event.Field.PublishedDate].Value
                        };
                        EventDetailsList.Add(eventdetails);
                    }
                }
            }

            EventDetails.EventDetails = EventDetailsList;
            EventDetails.Publisheddetails = PublisedDetailsList;
            return EventDetails;
        }

        public bool CheckDateIsValid(string date, List<PublishedDetails> Details)
        {
            bool Cheked = true;
            if (Details != null)
            {
                foreach (var published in Details)
                {
                    if (published.PublishedDate == date)
                    {
                         Cheked = false;
                         return Cheked;
                    }
                }  
            }

            return Cheked;
        }
    }
}