using ProjektPIZal.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjektPIZal.Models.ViewModels
{
    public class TeaVM
    {
        public TeaVM()
        {

        }
        public TeaVM(TeaDTO teaDTO)
        {
            this.TeaID = teaDTO.TeaID;
            this.Nazwa = teaDTO.Nazwa;
            this.Photo = teaDTO.Photo;
            this.Description = teaDTO.Description;
            this.Price = teaDTO.Price;

        }

        [DisplayName("Identyfikator")]
        public int TeaID { get; set; }
        [DisplayName("Nazwa")]
        public string Nazwa { get; set; }
        [DisplayName("Zdjęcie")]
        public string Photo { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }
        [DisplayName("Cena")]
        public decimal Price { get; set; }

    }
}
