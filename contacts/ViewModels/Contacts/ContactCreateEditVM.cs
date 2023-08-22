using Contacts.Models;
using System.ComponentModel.DataAnnotations;

namespace Contacts.ViewModels.Contacts
{
    public class ContactCreateEditVM : BaseVM
    {
        [Required]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [EmailAddress]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }
    }
}