using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;
using System.Text;

namespace WebStore.DataLayer.Entities.User
{
    [Table("Tbl_UserRole")]
    public class UserRole
    {
        public UserRole()
        {
            
        }

        [Key]
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }


        #region Relations

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

        #endregion
    }
}
