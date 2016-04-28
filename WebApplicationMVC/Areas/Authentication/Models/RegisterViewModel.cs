using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Areas.Authentication.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "نام کاربری / ایمیل")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "گذرواژه")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار گذرواژه")]
        [Compare("Password", ErrorMessage = "گذرواژه وارد شده و تکرار آن یکسان نیستند")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "شماره تماس")]
        public string PhoneNumber { get; set; }


    }
}