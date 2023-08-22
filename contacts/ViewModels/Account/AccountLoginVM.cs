using System.ComponentModel.DataAnnotations;

namespace Contacts.ViewModels.Account
{
    public class AccountLoginVM
    {
        [Required]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        public string RedirectUrl { get; set; }
    }
}