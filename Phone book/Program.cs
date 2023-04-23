using Phone_book;
using System;


namespace Phone_book
{

    class Program
    {
        static void Main(string[] args)
        {
            bool working = true;
            string consolText = null;
            var phonebook = new PhoneBook();
            Console.WriteLine("Welcome to the phone book application\n");
            while (working == true)
            {
                Console.WriteLine("If you want: \n- Add new contact press 1 \n- Find contact by name press 2 \n- Find contact by number press 3 \n- Remove contact press 4 \n- Viev all contacts press 5 \n- Create txt fille press 6  \n- Exit press 7\n");
                consolText = Console.ReadLine();
                if (consolText == "1")
                {
                    Console.WriteLine("Type name: ");
                    var name = Console.ReadLine();
                    if (String.IsNullOrEmpty(name))
                    {
                        while (String.IsNullOrEmpty(name))
                        {
                            Console.WriteLine("You didn't give a name \nType name: ");
                            name = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Type last name: ");
                    var lastName = Console.ReadLine();
                    if (String.IsNullOrEmpty(lastName))
                    {
                        while (String.IsNullOrEmpty(lastName))
                        {
                            Console.WriteLine("You didn't give a last name \nType last name: ");
                            lastName = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Type number: ");
                    var number = Console.ReadLine();
                    if (String.IsNullOrEmpty(number))
                    {
                        while (String.IsNullOrEmpty(number))
                        {
                            Console.WriteLine("You didn't give a number \nType number: ");
                            number = Console.ReadLine();
                        }
                    }

                    var contact = new Contact(name, lastName, number);
                    phonebook.AddContact(contact);
                }

                else if (consolText == "2")
                {
                    Console.WriteLine("Type name: ");
                    var name = Console.ReadLine();
                    phonebook.FindContactByName(name);

                }

                else if (consolText == "3")
                {
                    Console.WriteLine("Type number: ");
                    var number = Console.ReadLine();
                    phonebook.FindContactByNumber(number);
                }

                else if (consolText == "4")
                {
                    Console.WriteLine("Type name: ");
                    var name = Console.ReadLine();
                    phonebook.RemoveContact(name);

                }

                else if (consolText == "5")
                {
                    phonebook.ViewAll();
                }

                else if (consolText == "6")
                {
                    phonebook.CreateTxtFille();
                }

                else if (consolText == "7")
                {
                    working = false;

                }

                else Console.WriteLine("Error: Wrong number");
            }



        }
    }
}