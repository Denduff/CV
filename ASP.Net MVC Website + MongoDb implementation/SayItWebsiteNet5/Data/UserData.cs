using SayItWebsiteNet5.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SayItWebsiteNet5.Data
{
    public class UserData
    {

        public string Id { get; set; }
        [DisplayName("Nyt Kodeord")]
        public string Password { get; set; }
        [DisplayName("Bekræft Kodeord")]
        [Compare(nameof(Password), ErrorMessage = "Kodeord matcher ikke")]
        public string ConfirmPassword { get; set; }
        [DisplayName("Ny Email")]
        public string Email { get; set; }
        [DisplayName("Bekræft Email")]
        [Compare(nameof(Email), ErrorMessage = "Email matcher ikke")]
        public string ConfirmEmail { get; set; }
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [DisplayName("Bekræft Telefon")]
        [Compare(nameof(Phone), ErrorMessage = "Nummeret matcher ikke")]
        public string ConfirmPhone { get; set; }
        public ApplicationRole RoleToAdd { get; set; }

    }
}
