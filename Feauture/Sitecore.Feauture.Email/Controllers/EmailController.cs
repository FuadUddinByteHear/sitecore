using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Sitecore.Feauture.Email.Models;
using Sitecore.Feauture.Email.Repository;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Feauture.Email.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Email()
        {
            var datasourceid = RenderingContext.CurrentOrNull?.Rendering?.DataSource;
            var datasource = Sitecore.Context.Database.GetItem(datasourceid);
            ViewModel model = new ViewModel();
            ContactRepository repository = new ContactRepository();
            model.ContactInformation = repository.GetAllContactInformation(datasource);
            model.Email = new EmailModel();
            return View("~/Views/Email/Email.cshtml", model);
        }
        [HttpPost]
        public ActionResult Email(EmailModel email)
        {
            if (ModelState.IsValid)
            {
                string fieldvalues = "Hi there.. You Have a Message From" + email.CustomerName + " <br /> "+email.Message;
                string to = "2016-2-60-078@std.ewubd.edu";
                string froms =email.CustomerEmail ;
                MailMessage message = new MailMessage(froms, to);
                //string mailbody = 
                message.Subject = email.EmailSubject;
                message.Body = fieldvalues;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new System.Net.NetworkCredential("2016-2-60-078@std.ewubd.edu", "01933995018");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(message);
                    ViewBag.sendigmail = "Sucessfully Mail Sent";
                }
                catch (Exception ex)
                {
                    ViewBag.sendigmail = "Error while sending the mail";
                    throw ex;
                }
            }
            return View("~/Views/Email/Email.cshtml");
        }
    }
}