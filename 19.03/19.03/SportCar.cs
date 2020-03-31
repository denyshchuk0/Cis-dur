using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03
{
    class SportCar : Car
    {
        public SportCar(int max_speed)
        {
            this.Max_speed = max_speed;
            this.Model = "Sport";
            this.Distance = 0;
        }

        public override void Accelerate(int km)
        {
            Console.WriteLine("\n Sport ");
            base.Accelerate(km);
        }

        private static void FullStop(int stop)
        {
            Console.WriteLine("FullStop working ...");    
        }
        private static void Brake(int brake)
        {
            Console.WriteLine("Brake working ...");
        }
    }
 }
