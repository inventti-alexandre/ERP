using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Areas.Authentication.Models
{
    public class RoleViewModel
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "نام نقش")]
        public string Name { get; set; }

        [Display(Name = "عنوان نقش")]
        public string DisplayName { get; set; }

    }
}