using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Feauture.Speaker.Models;
using Sitecore.Foundation.Extension;
using Sitecore.Foundation.Extension.Extension;

namespace Sitecore.Feauture.Speaker.Repositorty
{
    public class SpeakerRepository
    {
        public List<SpeakerModel> GetAllSpeaker(Item item)
        {
            List<SpeakerModel> SpeakerList = new List<SpeakerModel>();
            if (item != null)
            {
                MultilistField Speakers = item.Fields[Template.Speaker.Field.SliderSpeakerList];
                Item[] SpeakersDetailsList = Speakers.GetItems();
                foreach (var SpeakerDetails in SpeakersDetailsList.ToList())
                {
                    LinkField facebookurl = item.Fields[Template.Speaker.Field.FacebookUrl];
                    LinkField twitterkurl = item.Fields[Template.Speaker.Field.TwitterUrl];
                    LinkField intagramurl = item.Fields[Template.Speaker.Field.InstagramUrl];
                    SpeakerModel Speaker = new SpeakerModel()
                    {
                        SpeakerProfilePic = SpeakerDetails.GetImageUrl(Template.Speaker.Field.SliderSpeakerList),
                        SpeakerName = SpeakerDetails.Fields[Template.Speaker.Field.Speakername].Value,
                        SpeakerOccupation = SpeakerDetails.Fields[Template.Speaker.Field.SpeakerPost].Value,
                        SpeakerFacebookLink = FieldExtension.GetGeneralLink(facebookurl),
                        SpeakerInstagramLink = FieldExtension.GetGeneralLink(intagramurl),
                        SpeakerTwitterLink = FieldExtension.GetGeneralLink(twitterkurl),
                    };
                    SpeakerList.Add(Speaker);
                }
            }
            return SpeakerList;
        }
        public List<SpeakerModel> GetAllSliderSpeaker(Item item)
        {
            List<SpeakerModel> SpeakerList = new List<SpeakerModel>();
            if (item != null)
            {
                MultilistField Speakers = item.Fields[Template.Speaker.Field.SliderSpeakerList];
                Item[] SpeakersDetailsList = Speakers.GetItems();
                foreach (var SpeakerDetails in SpeakersDetailsList.ToList())
                {
                    LinkField facebookurl = item.Fields[Template.Speaker.Field.FacebookUrl];
                    LinkField twitterkurl = item.Fields[Template.Speaker.Field.TwitterUrl];
                    LinkField intagramurl = item.Fields[Template.Speaker.Field.InstagramUrl];
                    SpeakerModel Speaker = new SpeakerModel()
                    {
                        SpeakerProfilePic = SpeakerDetails.GetImageUrl(Template.Speaker.Field.SliderSpeakerList),
                        SpeakerName = SpeakerDetails.Fields[Template.Speaker.Field.Speakername].Value,
                        SpeakerOccupation = SpeakerDetails.Fields[Template.Speaker.Field.SpeakerPost].Value,
                        SpeakerFacebookLink = FieldExtension.GetGeneralLink(facebookurl),
                        SpeakerInstagramLink = FieldExtension.GetGeneralLink(intagramurl),
                        SpeakerTwitterLink = FieldExtension.GetGeneralLink(twitterkurl),
                    };
                    SpeakerList.Add(Speaker);
                }
            }
            return SpeakerList;
        }
    }
}