using ProjektPIZal.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjektPIZal.Models.ViewModels
{
    public class CartVM
    {
        [DisplayName("Identyfikator")]
        public int CartID { get; set; }
        public int UserId { get; set; }
        [DisplayName("Koszyk")]
        public virtual ICollection<TeaDTO> TeasCart { get; set; }
        public CartVM()
        {

        }
        public CartVM(CartDTO cartDTO)
        {
            this.CartID = cartDTO.CartID;
            this.TeasCart = cartDTO.TeasCart;
        }
    }
}