using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFile
{
    class Program
    {
        /*
         Написати програму, яка шукає в вказаному каталозі HTML-файли
         та виводить їх список на екран в нумерованому вигляді.
         Після цього програма пропонує на вибір одну з наступних дій:
         Видалення обраного файла
	     Переіменування обраного файла
	     Редагування  обраного файла
         */
        static void Main(string[] args)
        {
            int count = 0;
            string path = @"E:\Folder";
            if (Directory.Exists(path))
            {
                string type = "*.html";
                var result = Directory.EnumerateFiles(path, type);
                foreach (var m in result)
                {
                    count++;
                    Console.WriteLine(count +". " + m);
                }
            }
            else
            {
                Console.WriteLine("No directory!");
            }
        }
    }
}
