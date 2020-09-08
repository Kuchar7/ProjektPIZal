using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjektPIZal.Models.Model
{
    [Table("tblUserRoles")]
    public class UserRoleDTO
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        [Key, Column(Order = 1)]
        public int RoleId { get; set; }
        [ForeignKey("UserId")]
        public virtual UserDTO UserDTO { get; set; }
        [ForeignKey("RoleId")]
        public virtual RoleDTO RoleDTO { get; set; }
    }
}