using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            //Початковий вклад в банку рівний 1000 грн.
            //    Через кожен місяць розмір вкладу збільшується на Р процентів від наявної суми(Р -дійсне число, 0 < P < 25).
            //Значення Р программа повинна отримувати від користувача.
            //    По даному Р программа повинна визначити, через скільки місяців розмір вкладу перевищить
            //    1100 грн.та вивести знайдену кількість місяців К(ціле число) та підсумковий розмір вкладу S(дійсне число).


            float vklad = 1000f;

            Console.WriteLine("Enter percent :");
            int percent = int.Parse(Console.ReadLine());

            int months = 0;
        
            while (true)
            {
                if (vklad >= 1100)
                {
                    Console.WriteLine("After {0} mounth Sum = {1}", months, vklad);
                    break;
                }
                else if (vklad < 1100)
                {
                    months++;
                    vklad += (vklad * percent) / 100;
                }
            }
            #endregion

        }
    }
}
