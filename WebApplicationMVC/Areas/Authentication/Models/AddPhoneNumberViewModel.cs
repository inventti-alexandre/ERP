using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Areas.Authentication.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}