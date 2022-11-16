using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feauture.EventSchuduleandticketpricing.Models
{
    public class EventModel
    {
        public List<EventDetails> EventDetails { get; set; }

        public List<PublishedDetails> Publisheddetails { get; set; }
    }

    public class PublishedDetails
    {
        public string PublishedDate { get; set; }
        public string TabIdName { get; set; }
        public string TargetedTab { get; set; }
    }
    public class EventDetails
    {
        public string StartingTime { get; set; }
        public string EndingTime { get; set; }
        public string SpeakerImage { get; set; }
        public string SpeakerName { get; set; }
        public string SpeakerOcupation { get; set; }
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public string PublishedDate { get; set; }
        public List<PublishedDetails> Publisheddetails { get; set; }
    }
}