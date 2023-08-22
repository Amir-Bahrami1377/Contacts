using System.ComponentModel.DataAnnotations;

namespace Contacts.ViewModels.Account
{
    public class AccountRegisterVM : BaseVM
    {
        [Required]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2)]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز عبور")]
        [Compare("Password")]
        public string RepeatPassword { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name ="ایمیل")]
        public string Email { get; set; }

    }
}