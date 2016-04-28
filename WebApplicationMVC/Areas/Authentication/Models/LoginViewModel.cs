using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Areas.Authentication.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "نام کاربری / ایمیل")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "گذرواژه")]
        public string Password { get; set; }

        [Display(Name = "مرا بخاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}