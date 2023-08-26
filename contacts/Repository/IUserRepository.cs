using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Contacts.Models;

namespace Contacts.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllUsers(Expression<Func<User, bool>> filter = null);
        User GetUserById(int id);
        void InsertUser(User user);
    }
}
