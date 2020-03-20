using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        //        Створити власний об”єкт “Телефонна книга” з власним індексатором
        //1. Обє”єм 100 телефонів
        //2. 50% з них повинні бути встановлені конструктором при створенні
        //екземпляра довідника, значення вносяться випадковим чином.
        //3. Реалізувати модель CRUD для довідника:

        //- додавання номерів - якщо в словнику є вільні або незаповенні поля
        //можна додати новий телефонний номер, вільним поле вважається
        //якщо в ньому знаходяться дані по замовчуванню або пуста строка

        //- читання всього словника, посторінково, тобто на консоль зараз
        //виводити обмежену к-сть записів а далі очікувати натискання
        //клавіши, після чого виводити наступну порцію даних, повинно
        //відображатися інформація про поточну сторінку і про загальну
        //кількість сторінок: 1 з 5, 2 з 5, 3 з 5 ...

        //- редагування існуючого номера телефона або інформаціїї прив”язаної
        //до нього

        //- видалення номера з довідника - поля повинні бути перезаписані
        //значеннями по замовчуванню

        //- пошук даних по ключу-номеру або по частині відомої інформації:
        //наприклад відомо ім”я Іван - знайде всіх Іванів і виведе на екран, якщо їх
        //більше ніж може вмістити консоль за раз, буде виводити по
        //сторінках

        //- описати індексатори для встановлення даних на позицію, для
        //встановлення даних по номеру(типу строка), для отримання даних
        //по номеру елемента, для отримання даних по номеру(ключ-строка-
        //номер телефона)


        //У довідника повинні бути наступні поля і методи для роботи з ними:
        //- Ім”я - строка задається при створенні
        //- Дата створення - задається при створенні від часу на момент
        //створення
        //- Кількість зайнятих телефонів - методи лоя отримання інформації
        //з цього поля і методи які змінюють його значення при додаванні
        //телефонів/видаленні їх
        static void Main(string[] args)
        {
            PhoneList phoneList = new PhoneList();

        // Default phones
            phoneList[0] = new Phone { Name = "Tom", Number = "0976453265" };
            phoneList.AddPhone("Bill", "0987654709");
            phoneList.AddPhone("Sergey", "0966723509");
            phoneList.AddPhone("Roma", "0932454363");
            phoneList.AddPhone("Andrey", "0947362537");
            phoneList.AddPhone("Misha", "0933526478");
        // Default phones

            int change;
            string name;
            string number;
            while (true)
            {
                Console.WriteLine("---------------MENU-----------------\n" +
                             "1.Show all catalog\n" +
                             "2.Add new phone\n" +
                             "3.Find by name\n" +
                             "4.Delete by name\n" +
                             "--->>");
                change = int.Parse(Console.ReadLine());
                switch (change)
                {
                    case 1:
                        phoneList.ShowList();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Enter Add name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Add number: ");
                        number = Console.ReadLine();
                        phoneList.AddPhone(name, number);
                        Console.WriteLine("press any botoon");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine();
                        phoneList.FindPhone(name);
                        Console.WriteLine("press any botoon");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Enter name by delete: ");
                        name = Console.ReadLine();
                        phoneList.DeletePhone(name);
                        Console.WriteLine("press any botoon");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
