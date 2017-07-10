using System.ComponentModel.DataAnnotations;

namespace sharepointseanmvc.Models
{
    public class MailModel
    {
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string From { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string To { get; set; }

        [Required(ErrorMessage = "The subject is required")]
        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}
