using System.Collections.Generic;

namespace Contacts.Models
{
    public class Contact : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }

        public virtual List<Phone> Phones { get; set; }

        public virtual string FullName => $"{FirstName} {LastName}";
    }
}