using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBooks
{
    public class PhoneBook
    {
        public string OwnerPhoneBook { get; set; }

        public List<Contact> Contacts { get; set; }

        public PhoneBook()
        {

        }

        public PhoneBook(string OwnerPhoneBook)
        {
            this.OwnerPhoneBook = OwnerPhoneBook;
            this.Contacts = new List<Contact>();
        }

        public void Add(Contact contact)
        {
            Contacts.Add(contact);
        }
    }
}
