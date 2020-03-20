using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Bird : Animal
    {
        protected override void Biom()
        {
            Console.WriteLine("Bird live on treas");
        }

        protected override void Movement()
        {
            Console.WriteLine("Bird can fly");
        }

        protected override void Eat()
        {
            Console.WriteLine("Bird eat worm");
        }

        public void ShowInfo()
        {
            Biom();
            Movement();
            Eat();
        }
    }
}
