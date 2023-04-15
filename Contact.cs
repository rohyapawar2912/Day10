using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Contact
    {
    public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Phone Number: {PhoneNumber}, Email: {Email}";
        }
    }

    class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        public Contact FindContact(string name)
        {
            return contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
            }
            else
            {
                Console.WriteLine("Contacts:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
        }
    }
}

