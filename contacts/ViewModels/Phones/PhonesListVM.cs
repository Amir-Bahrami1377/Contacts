using Contacts.Models;

namespace Contacts.ViewModels.Phones
{
    public class PhonesListVM : BaseListVM<Phone>
    {
        public Contact Contact { get; set; }
    }
}