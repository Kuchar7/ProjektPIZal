using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjektPIZal.Models.Model
{
    [Table("tblTeas")]
    public class TeaDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeaID { get; set; }
        public string Nazwa { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<CartDTO> Carts { get; set; }
    }
}