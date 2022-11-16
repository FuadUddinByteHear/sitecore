using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sitecore.Feauture.Email.Models
{
    public class EmailModel
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email Address")]
        public string CustomerEmail { get; set; }
        [Required(ErrorMessage = "Please Enter Subject")]
        public string EmailSubject { get; set; }
        [Required(ErrorMessage = "Please Enter Your Message")]
        public string Message { get; set; }
    }
}