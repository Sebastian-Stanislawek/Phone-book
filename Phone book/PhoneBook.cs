using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phone_book
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        private int number = 0;

        public void RemoveContact(string name)
        {
            Contact? foundContanctName = null;
            bool found = false;
            foreach (Contact contact in Contacts)
            {
                if (contact.FirstName == name)
                {
                    found = true;
                    foundContanctName = contact;
                    break;
                }
            }

            if (found == true)
            {
                Contacts.Remove(foundContanctName);
                Console.WriteLine("Contact removed successfully\n");
            }

            else Console.WriteLine("Contact not found\n");
        }
        public void FindContactByName(string name)
        {
            string? foundContanctName = null;
            string? foundContanctLastName = null;
            string? foundContanctPhone = null;
            bool found = false;
            foreach(Contact contact in Contacts)
            {
                if (contact.FirstName == name)
                {
                    found=true;
                    foundContanctName = contact.FirstName;
                    foundContanctPhone = contact.PhoneNumber;
                    foundContanctLastName = contact.LastName;
                    break;
                }               
            }

            if (found == true)
            {
                Console.WriteLine("Name: " + foundContanctName + " \nLast name: " + foundContanctLastName + " \nPhone: " + foundContanctPhone + "\n");
            }

            else  Console.WriteLine("Name not found\n");
        }
        public void FindContactByNumber(string number)
        {
            string? foundContanctName = null;
            string? foundContanctLastName = null;
            string? foundContanctPhone = null;
            bool found = false;
            foreach (Contact contact in Contacts)
            {
                if (contact.PhoneNumber == number)
                {
                    found = true;
                    foundContanctName = contact.FirstName;
                    foundContanctPhone = contact.PhoneNumber;
                    foundContanctLastName = contact.LastName;
                    break;
                }
            }

            if (found == true)
            {
                Console.WriteLine("Name: " + foundContanctName + " \nLast name: " + foundContanctLastName + " \nPhone: " + foundContanctPhone + "\n");
            }

            else Console.WriteLine("Number not found\n");
        }

        public void ViewAll()

        {
            foreach(Contact contact in Contacts)
            {
                Console.WriteLine("First Name: " + contact.FirstName + " \nLast Name: " + contact.LastName + " \nPhone Number: " + contact.PhoneNumber + "\n");
            }

        }

        public void CreateTxtFille() //Default file path "Phone Book/Phone Book/bin/Debug/net6.0"
        {
            string fileName = string.Format("contacts_{0}.txt", number);
            StreamWriter contacts = new StreamWriter(fileName);

            foreach (Contact contact in Contacts)
            {
                contacts.WriteLine("Name: {0} \nLast name: {1} \nNumber: {2}\n", contact.FirstName, contact.LastName, contact.PhoneNumber);
            }
            contacts.Close();
            number++;
        }

    }
}
