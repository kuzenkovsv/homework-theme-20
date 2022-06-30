using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBooks
{
    public class Contact
    {
        public int Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public Contact()
        {

        }

        public Contact(int Id, string Surname, string Name, string MiddleName, string PhoneNumber, string Address, string Description)
        {
            this.Id = Id;
            this.Surname = Surname;
            this.Name = Name;
            this.MiddleName = MiddleName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Description = Description;
        }
    }
}
