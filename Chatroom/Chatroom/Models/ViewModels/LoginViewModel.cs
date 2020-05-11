using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chatroom.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Gebruikersnaam")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }
    }
}