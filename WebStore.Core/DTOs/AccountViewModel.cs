using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebStore.Core.DTOs
{
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string UserEmail { get; set; }

        [Display(Name = "کلمه عبور")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string UserPassword { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Compare("UserPassword", ErrorMessage = "کلمات عبور مغایرت دارند")]
        public string UserRePassword { get; set; }
    }
}
