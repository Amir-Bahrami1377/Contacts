using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Contacts.Models
{
    public class ContactsDB : DbContext
    {
        public ContactsDB() : base("DefaulConnection") { }
        public DbSet<Contact> Contacts { get; set;}
        public DbSet<User> Users { get; set;}
        public DbSet<Phone> Phones { get; set;}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}