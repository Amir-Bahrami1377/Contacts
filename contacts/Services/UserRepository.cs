using Contacts.Models;
using Contacts.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Contacts.Services
{
    public class UserRepository : IUserRepository
    {
        private ContactsDB db;
        public UserRepository(ContactsDB context) 
        {
            db = context;
        }
        public List<User> GetAllUsers(Expression<Func<User, bool>> filter = null)
        {
            if (filter != null)
            {
                return db.Users.Where(filter).ToList();
            }
            else
            {
                return db.Users.ToList();
            }
        }
        public User GetUserById(int id)
        {
            return db.Users.Find(id);
        }

        public void InsertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}