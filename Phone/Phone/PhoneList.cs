using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class PhoneList
    {
        Phone[] phone = new Phone[50];

        public PhoneList()
        {
            for (int i = 0; i < phone.Length; i++) {
               this.phone[i] = new Phone();
            }
        }

        public Phone this[int index] 
        {
            get
            {
                return this.phone[index];
            }
            set
            {
                this.phone[index] = value;
            }
        }

        public void AddPhone(string name, string number) {
            foreach (Phone item in this.phone)
            {
                if (item.Name == "name") {
                    item.Name = name;
                    item.Number = number;
                    break;
                }
            }
        }
        public void ChangePhone(string name)
        { 
            foreach (Phone item in this.phone)
            {
                if (item.Name == name)
                {
                    Console.WriteLine($"{item.Number} - {item.Name}");
                    Console.Write("Enter new name : ");
                    item.Name = Console.ReadLine();
                    Console.Write("Enter new number : ");
                    item.Number = Console.ReadLine();
                    break;
                }
            }
        }

        public void FindPhone(string name)
        {
            int count = 0;
            int pageCount = 0;
            foreach (Phone item in this.phone)
            {
                if (item.Name == name)
                {
                    count++;
                    if (count >= 10)
                    {
                        pageCount++;
                        Console.WriteLine($"---{pageCount} from 5---");
                        Console.WriteLine("press any botoon");
                        Console.ReadKey(true);
                        count = 0;
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine($"{item.Number} - {item.Name}");
                    }
                }
            }
        }

        public void DeletePhone(string name)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i].Name == name)
                {
                    phone[i] = new Phone();
                    break;
                }
            }
        }

        public void ShowList()
        {
            int count = 0;
            int pageCount = 0;
            foreach (Phone item in this.phone)
            {
                count++;
                if (count >= 10)
                {
                    pageCount++;
                    Console.WriteLine($"--- {pageCount} from 5 ---");
                    Console.WriteLine("press any botoon");
                    Console.ReadKey(true);
                    count = 0;
                    Console.Clear();
                    continue;
                }
                else {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine($"{item.Number} - {item.Name}");
                }
            }
        }
    }
}
