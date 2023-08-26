using Contacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Repositories
{
    public interface IContactRepository
    {
        List<Contact> GetAllContacts(Expression<Func<Contact, bool>> filter = null);
        Contact GetContactById(int id);
        void InsertContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
        void Save(Contact contact);
    }
}
