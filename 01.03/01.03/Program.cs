using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //    // 1.Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
            //    // Определить сумму элементов массива, расположенных
            //    //между минимальным и максимальным элементами.

            //    int[,] arr = new int[5,5];
            //    Random rand = new Random();

            //    int max=0;
            //    int maxI=0;
            //    int maxJ=0;
            //    int min=0;
            //    int minI=0;
            //    int minJ=0;
            //    int sum = 0;

            //    for (int i = 0; i < 5; i++) {
            //        for (int j = 0; j < 5; j++) {
            //            arr[i,j] = rand.Next(-100, 100);

            //            Console.Write("["+arr[i, j]+"] ");

            //            if (arr[i, j] > max)
            //            {
            //                max = arr[i, j];
            //            }
            //            else if (arr[i, j] < min)
            //            {
            //                min = arr[i, j];
            //            }

            //        }
            //        Console.WriteLine("\n");
            //    }

            //    for (int i = 0; i < 5; i++)
            //    { 
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (arr[i, j].Equals(min))
            //            {
            //                minI = i;
            //                minJ = j;
            //            }
            //            else if (arr[i, j].Equals(max)) {
            //                maxI = i;
            //                maxJ = j;
            //            }
            //        }
            //    }
            //    Console.WriteLine("Min = " + min);
            //    Console.WriteLine("Max = " + max);
            //    for (int i = minI; i < 5; i++)
            //    {
            //        for (int j = minJ; j < 5; j++)
            //        {
            //            if (i == maxI && j == maxJ)
            //            {
            //                break;
            //            }
            //            else {
            //                sum=arr[i, j];
            //            }
            //        }

            //    }
            //    Console.WriteLine("Sum = " + sum);
            //}


            #endregion
            #region
            //2.Заполнить массив случайными числами, вывести его на экран. Найти
            //самую длинную последовательность чисел, упорядоченную по
            //возрастанию.Вывести ее на экран. Если таких последовательностей
            //несколько(самых длинных с одинаковой длиной), то вывести их все.
            Random rand = new Random();
            int size = 30;
            int[] arr = new int[size];

            for (int i = 0; i < size; i++) {
                arr[i] = rand.Next(100);
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
            #endregion
        }
    }
}
