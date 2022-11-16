using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feauture.Speaker
{
    public class Template
    {
        public struct Speaker
        {
            public static readonly ID speakerstemplateid = new ID("{AA68152D-8F33-4D95-A740-1C9C94987329}");
            public struct Field
            {
                public static readonly ID Profilepic = new ID("{72282DE7-14EF-4183-B599-4E196C1EE7F7}");
                public static readonly ID Speakername = new ID("{3A6826CC-9E5E-4298-9130-2A4E03D563CB}");
                public static readonly ID SpeakerPost = new ID("{2441EAF4-761D-4562-8FD7-40024C56D7AE}");
                public static readonly ID FacebookUrl = new ID("{415EE2C2-054B-4C83-AE6E-02E49A516521}");
                public static readonly ID InstagramUrl = new ID("{61291114-9EB3-4A55-BCF0-E70CBAA57E64}");
                public static readonly ID TwitterUrl = new ID("{1C61F608-75AB-4348-B383-D16949DE2A53}");
                public static readonly ID SliderSpeakerList = new ID("{4623F1D4-5BE9-4475-8FE9-C52FF6FD80B5}");
                public static readonly ID AllSpeakersList = new ID("{11BE821E-4CA6-4D83-9182-6F233B59CC2D}");
            }
        }
    }
}