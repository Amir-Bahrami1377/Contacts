using Contacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Repositories
{
    public interface IPhoneRepository
    {
        Phone GetPhoneById(int id);
        void InsertPhone(Phone phone);
        void UpdatePhone(Phone phone);
        void DeletePhone(Phone phone);
        void Save(Phone phone);
    }
}
