using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
//        Завдання:
//Написати програму для виконання операцій з одновимірним масивом за
//допомогою делегатів.Користувачу надається наступне меню для вибору типа
//операції з масивом:
//1. обчислення значення
//2. зміна масиву
//Якщо користувач вибрав 1-й тип, вивести підменю вибору операції:
//i.Обчислити кількість негативних елементів
//ii.Визначити суму всіх елементів

//2-й тип:
//i.Змінити всі негативні елементи на 0
//ii.Відсортувати масив

// Створити вказані вище методи та реалізувати вибір користувачем операції на
// виконання без використання конструкцій if, switch та?:(тернарного) оператора.
//Методи першого типу повинні повертати результат обчислення, в той час методи
// другого типу – void.
//Реалізувати валідацію вибраного номера операції.
        static Masiv masiv;
        static void Main(string[] args)
        {
            masiv = new Masiv();
            masiv.FillArr();
            masiv.RegisterOnSum(NegativeHandler);
            masiv.SumNegative();
            masiv.RegisterOnSum(AllHandler);
            masiv.SumAll();


        }
        private static int NegativeHandler()
        {
        
            Console.WriteLine("\nNegative working ...");
            return masiv.SumN();
           
        }
        private static int AllHandler()
        {
            Console.WriteLine("Sum All working ...");
            return masiv.SumA();
            
        }
    }
}
