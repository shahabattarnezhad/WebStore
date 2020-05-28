using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebStore.DataLayer.Entities.User
{
    [Table("Tbl_User")]
    public class User
    {
        public User()
        {
            
        }

        [Key]
        public int UserId { get; set; }

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

        [Display(Name = "کد فعال سازی")]
        [MaxLength(50, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string UserActiveCode { get; set; }

        [Display(Name = "وضعیت")]
        public bool UserIsActive { get; set; }

        [Display(Name = "آواتار")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string UserAvatar { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime UserRegisterDate { get; set; }

        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }

        #endregion
    }
}
