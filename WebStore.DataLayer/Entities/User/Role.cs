using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebStore.DataLayer.Entities.User
{
    [Table("Tbl_Role")]
    public class Role
    {
        public Role()
        {
            
        }

        [Key]
        public int RoleId { get; set; }


        [Display(Name ="")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string RoleName { get; set; }

        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }

        #endregion
    }
}
