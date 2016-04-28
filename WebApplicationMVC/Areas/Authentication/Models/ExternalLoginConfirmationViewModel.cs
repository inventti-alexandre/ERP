using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Areas.Authentication.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}