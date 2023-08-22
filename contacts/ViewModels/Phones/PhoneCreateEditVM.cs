using Contacts.Models;
using System.ComponentModel.DataAnnotations;


namespace Contacts.ViewModels.Phones
{
    public class PhoneCreateEditVM : BaseVM
    {
        [Required]
        [Display(Name = "شماره تماس")]
        [Phone(ErrorMessage = "فقط از اعداد استفاده کنید")]
        public string PhoneNumber { get; set; }

        public int ContactID { get; set; }

        public Contact Contact { get; set; }
    }
}