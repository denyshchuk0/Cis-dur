using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    class Program
//<h5>Завдання 1 (Практикум на парі)</h5>
//<p>
//Написати XML-документ для збереження даних<b>про облікові записи користувачів</b>.
//Про кожнен обліковий запис в документі зберігаються дані про:
//<ul><li>Ім'я користувача</li>
//<li>Логін</li>
//<li>Пароль</li>
//<li>Дата створення облікового запису</li>
//</ul>
//Додати в док
//    Реалізувати можливість: Додати/видвлити/редагувати/ користувача.
//Зробити можливість імпорту в html
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            int choice;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("------------MENU------------" +
                                  "\n1. Fill file"+
                                  "\n2. Add elemet"+
                                  "\n3. Show elemets"+
                                  "\n4. Remove elemet"+
                                  "\n5. Import HTML"+
                                  "\n6. Valide"+
                                  "\n0. Exit"+
                                  "\n---->>");
                choice = int.Parse(Console.ReadLine());

                switch (choice) {
                    case 1:
                        menu.Fill();
                        break;
                    case 2:
                        menu.Add();
                        break;
                    case 3:
                        menu.Show();
                        break;
                    case 4:
                        menu.Remove();
                        break;
                    case 5:
                        menu.ImportHtml();
                        break;
                    case 6:
                        menu.Valid();
                        break;
                    case 0:
                        exit = true;
                        break;
                }
            }
        }
    }
}
