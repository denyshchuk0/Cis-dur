using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    /*Написати програму, яка шукає в вказаному каталозі HTML-файли та виводить їх список на екран в нумерованому вигляді. 
Після цього програма пропонує на вибір одну з наступних дій:
Видалення обраного файла
Переіменування обраного файла
	Редагування  обраного файла
     */
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Folder";
            WorkFile work = new WorkFile(path);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine(
                    " 1. Show files HTML\n" +
                    " 2. Delete file\n" +
                    " 3. Rename file\n" +
                    " 4. Edit file (add text)\n" +
                    " 0. Exit \n" +
                    " >>> ");
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        work.Show();
                        Console.WriteLine("\nPress anykey to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        work.Show();
                        work.Delete_file();
                        Console.WriteLine("\nPress anykey to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        work.Show();
                        work.Rename();
                        Console.WriteLine("\nPress anykey to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        work.Show();
                        work.Add_text_to_file();
                        Console.WriteLine("\nPress anykey to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        exit = true;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
