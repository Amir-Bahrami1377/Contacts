using Contacts.Repositories;
using Contacts.Services;
using Contacts.Models;
using System;

namespace Contacts.Services
{
    public class UnitOfWork : IDisposable
    {
        ContactsDB db = new ContactsDB();

        private IUserRepository _userRepository;
        private IContactRepository _contactRepository;
        private IPhoneRepository _phoneRepository;

        public IUserRepository UserRepository 
        { get 
            {
                if (_userRepository==null)
                {
                    _userRepository = new UserRepository(db);
                }
                return _userRepository;
            }
        }
        public IContactRepository ContactRepository
        {
            get
            {
                if (_contactRepository == null)
                {
                    _contactRepository = new ContactRepository(db);
                }
                return _contactRepository;
            }
        }
        public IPhoneRepository PhoneRepository
        {
            get
            {
                if (_phoneRepository == null)
                {
                    _phoneRepository = new PhoneRepository(db);
                }
                return _phoneRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}