using Contacts.Models;
using PagedList;

namespace Contacts.ViewModels.Contacts
{
    public class ContactsListVM : BaseListVM<Contact>
    {
        public PagedList<Contact> PagedContacts { get; set; }

        public int? Page { get; set; }

        public string SearchString { get; set; }
    }
}