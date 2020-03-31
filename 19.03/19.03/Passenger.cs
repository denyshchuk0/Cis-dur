using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03
{
    class Passenger : Car
    {
        public Passenger(int max_speed)
        {
            this.Max_speed = max_speed;
            this.Model = "Passenger";
            this.Distance = 0;
        }

        public override void Accelerate(int km)
        {
            Console.WriteLine("\n Passenger ");
            base.Accelerate(km);
        }
    }
}
