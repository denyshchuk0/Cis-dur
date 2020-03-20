using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Fish : Animal
    {
        protected override void Biom()
        {
            Console.WriteLine("Fish live in water");
        }

        protected override void Movement()
        {
            Console.WriteLine("Fish can swim");
        }

        protected override void Eat()
        {
            Console.WriteLine("Fish eat plancton");
        }

        public void ShowInfo() {
            Biom();
            Movement();
            Eat();
        }


    }
}
