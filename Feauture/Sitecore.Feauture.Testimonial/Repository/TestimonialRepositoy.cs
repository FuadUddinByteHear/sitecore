using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Feauture.Testimonial.Models;
using Sitecore.Foundation.Extension.Extension;

namespace Sitecore.Feauture.Testimonial.Repository
{
    public class TestimonialRepositoy
    {
        public List<TestimonialModel> GetAllTestimonial(Item item)
        {
            List<TestimonialModel> Testimonials = new List<TestimonialModel>();
            if (item != null)
            {
                if (item.HasChildren)
                {
                    foreach (var testimonialitem in item.GetChildren().ToList())
                    {
                        TestimonialModel testimonial = new TestimonialModel()
                        {
                            CustomerProfilePic =
                                testimonialitem.GetImageUrl(Template.Testimonial.Field.CustomerProfilePic),
                            CustomerName = testimonialitem.Fields[Template.Testimonial.Field.CustomerName].Value,
                            CustomerTestimonial = testimonialitem.Fields[Template.Testimonial.Field.CustomerTestimonial]
                                .Value,
                            CustomerOccupation = testimonialitem.Fields[Template.Testimonial.Field.CustomerOccupation]
                                .Value
                        };
                        Testimonials.Add(testimonial);
                    }
                }
            }

            return Testimonials;
        }
    }
}