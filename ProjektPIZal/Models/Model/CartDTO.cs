using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjektPIZal.Models.Model
{
    public class CartDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartID { get; set; }
        public virtual ICollection<TeaDTO> TeasCart { get; set; }
        public int UserId { get; set; }
        public UserDTO UserDTO { get; set; }
    }
}