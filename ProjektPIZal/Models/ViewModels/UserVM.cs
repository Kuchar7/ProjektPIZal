using ProjektPIZal.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektPIZal.Models.ViewModels
{
    public class UserVM
    {
        public UserVM()
        {

        }
        public UserVM(UserDTO userDTO)
        {
            this.UserID = userDTO.UserID;
            this.EmailAddress = userDTO.EmailAddress;
            this.Password = userDTO.Password;
            this.FirstName = userDTO.FirstName;
            this.LastName = userDTO.LastName;

        }


        [DisplayName("Identyfikator")]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Wymagane podanie adresu E-mail!")]
        [DisplayName("Adres E-mail")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [DisplayName("Hasło")]
        [Required(ErrorMessage = "Wymagane podanie hasła!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Potwierdzenie hasła")]
        [Required(ErrorMessage = "Wymagane potwierdzenie hasła!")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }
        [DisplayName("Imię")]
        [Required(ErrorMessage = "Wymagane podanie imienia!")]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        [Required(ErrorMessage = "Wymagane podanie nazwiska!")]
        public string LastName { get; set; }
    }
}