using Contacts.Models;
using Contacts.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Contacts.Services
{
    public class PhoneRepository : IPhoneRepository
    {
        private ContactsDB db;
        public PhoneRepository(ContactsDB context) 
        {
            db = context;
        }

        public void DeletePhone(Phone phone)
        {
            db.Phones.Remove(phone);
            db.SaveChanges();
        }

        public Phone GetPhoneById(int id)
        {
            return db.Phones.Find(id);
        }

        public void InsertPhone(Phone phone)
        {
            db.Phones.Add(phone);
            db.SaveChanges();
        }

        public void Save(Phone phone)
        {
            if (phone.ID > 0)
            {
                UpdatePhone(phone);
            }
            else
            {
                InsertPhone(phone);
            }
        }

        public void UpdatePhone(Phone phone)
        {
            db.Entry(phone).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}