using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    class Accounts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Date { get; set; }

        public static Accounts[] GetAllSContacts()
        {

            Console.WriteLine("How many accounts you want to add:");
            int size = int.Parse(Console.ReadLine());
            Accounts[] contacts = new Accounts[size];
            for (int i = 0; i < size; i++)
            {
                contacts[i] = new Accounts();
                contacts[i].Id = i + 1;
                Console.WriteLine("Enter Name: ");
                contacts[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Login: ");
                contacts[i].Login = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                contacts[i].Password = Console.ReadLine();
                Console.WriteLine("Enter Date of Create account: ");
                contacts[i].Date = Console.ReadLine();
            }
            return contacts;
        }

    }
}
