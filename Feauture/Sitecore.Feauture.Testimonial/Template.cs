using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feauture.Testimonial
{
    public class Template
    {
        public struct Testimonial
        {
            public static readonly ID TesimonialTemplateId = new ID("{2937AA06-5153-4604-8146-C6FE477D33F5}");
            public struct Field
            {
                public static readonly ID CustomerName = new ID("{1CDB0423-1D85-4D23-8CC3-0F12A4E971BB}");
                public static readonly ID CustomerProfilePic = new ID("{7E140164-5971-4566-895C-08F31DF16320}");
                public static readonly ID CustomerTestimonial = new ID("{E6A466C7-BD85-44C2-930C-02BBC8D2CF6F}");
                public static readonly ID CustomerOccupation = new ID("{FD93EC72-C7A8-4535-B60D-E40038248DB9}");
            }
        }
    }
}