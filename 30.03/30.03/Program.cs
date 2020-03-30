using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //1. Створити узагальнюючий клас, який містить список елементів (List< T >) та реалізує роботу з ним,
            //включаючи сортування. Клас описати за допомогою узагальнюючих алгоритмів Generics. Сортування реалізувати довільним методом 
            //(вибором, бульбашковим тощо).
            List<int> arr = new List<int>();

            arr.Add(54);
            arr.Add(99);
            arr.Add(3);
            arr.Add(34);
            arr.Add(111);
            arr.Add(13);
            arr.Add(54);
            arr.Add(6);

            using (Elements elements = new Elements(arr))
            {
                elements.Sorting();
                foreach (var item in elements)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("------------------------------------");
            #endregion

            //2. метод, який дозволяє підрахувати скільки разів кожне слово зустрічається в заданому тексті. 
            //Результат записати в колекцію Dictionary<TKey, TValue>.

            Dictionary<string, int> dict = new Dictionary<string, int>();
            string text = "This is the simple text This This is the simple text This";
            string[] words = text.Split(' '); //divide string

            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    dict.Add(words[i], 1);
                }
                catch (ArgumentException)
                {
                    dict[words[i]] += 1;
                }
            }

            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"Key: {item.Key}\t\t Value: {item.Value}");
            }
        }
    }
}
