using Contacts.Models;
using Contacts.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Contacts.Services
{
    public class ContactRepository : IContactRepository
    {
        private ContactsDB db;
        public ContactRepository(ContactsDB context) 
        {
            db = context;
        }
        public void DeleteContact(Contact contact)
        {
            db.Contacts.Remove(contact);
            db.SaveChanges();
        }
        public List<Contact> GetAllContacts(Expression<Func<Contact, bool>> filter = null)
        {
            if (filter != null)
            {
                return db.Contacts.Where(filter).ToList();
            }
            else
            {
                return db.Contacts.ToList();
            }
        }

        public Contact GetContactById(int id)
        {
            return db.Contacts.Find(id);
        }

        public void InsertContact(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        public void Save(Contact contact)
        {
            if (contact.ID > 0)
            {
                UpdateContact(contact);
            }
            else
            {
                InsertContact(contact);
            }
        }

        public void UpdateContact(Contact contact)
        {
            db.Entry(contact).State = EntityState.Modified;
            //db.Contacts.AddOrUpdate(contact);
            db.SaveChanges();
        }
    }
}