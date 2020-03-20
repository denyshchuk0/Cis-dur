using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Reptile : Animal
    {

        protected override void Biom()
        {
            Console.WriteLine("Reptile live near water");
        }

        protected override void Movement()
        {
            Console.WriteLine("Reptile can crawl");
        }

        protected override void Eat()
        {
            Console.WriteLine("Reptile eat trash");
        }

        public void ShowInfo()
        {
            Biom();
            Movement();
            Eat();
        }
    }
}
