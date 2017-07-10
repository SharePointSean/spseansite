using System.Web.Mvc;
using System.Net.Mail;

namespace sharepointseanmvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(Models.MailModel _objModelMail)
        {
            try { 
                MailMessage mail = new MailMessage();
                mail.To.Add("sean@sharepointsean.com");
                mail.From = new MailAddress(_objModelMail.From);
                mail.Subject = _objModelMail.Subject;
                string body = _objModelMail.Body;
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "mail.noip.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("","");  //Removed for security
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return "Your message has been sent. Click the Close button to close this form.";
            }
            catch(System.Exception)
            {
                return "An error occured and your message was not sent. Please contact sean@sharepointsean.com to let them know something went wrong.";
            }
        }
    }
}