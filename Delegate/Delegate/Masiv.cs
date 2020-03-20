using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Masiv
    {
        int[] arr =new int [5];
        Random rand = new Random();

        public delegate int SumDelegate();
        private SumDelegate sum;
        public delegate void ChangeDelegate();
        private ChangeDelegate change;

        public void RegisterOnSum(SumDelegate sum)
        {
            this.sum = sum;
        }
        public void RegisterOnChange(ChangeDelegate change)
        {
            this.change = change;
        }

        public void FillArr()
        {
            Console.WriteLine("Filed...");
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = rand.Next(-10, 10);
                Console.Write("[ "+arr[i]+"]");
            }
        }

        public void SumNegative()
        {
                 Console.WriteLine("Sum of negative = "+sum());
        }

        public void SumAll()
        {
          Console.WriteLine($"Sum all ="+sum());
        }

        public int SumN() {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (this.arr[i] < 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public int SumA()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
