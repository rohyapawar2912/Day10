namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Address Book Management System");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Remove Contact");
                Console.WriteLine("3. Find Contact");
                Console.WriteLine("4. Display Contacts");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();

                        Contact newContact = new Contact(name, phoneNumber, email);
                        addressBook.AddContact(newContact);

                        Console.WriteLine("Contact added successfully!");
                        break;
                    case "2":
                        Console.Write("Enter Name to remove: ");
                        string nameToRemove = Console.ReadLine();
                        Contact contactToRemove = addressBook.FindContact(nameToRemove);
                        if (contactToRemove != null)
                        {
                            addressBook.RemoveContact(contactToRemove);
                            Console.WriteLine("Contact removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter Name to find: ");
                        string nameToFind = Console.ReadLine();
                        Contact contactToFind = addressBook.FindContact(nameToFind);
                        if (contactToFind != null)
                        {
                            Console.WriteLine(contactToFind);
                        }
                        else
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;
                    case "4":
                        addressBook.DisplayContacts();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for using the Address Book Management System. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

}