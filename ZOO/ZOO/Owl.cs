using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Owl : Animal
    {
        protected override void Biom()
        {
            Console.WriteLine("Owl live on earsh");
        }

        protected override void Movement()
        {
            Console.WriteLine("Owl can run");
        }

        protected override void Eat()
        {
            Console.WriteLine("Owl eat meats");
        }

        public void ShowInfo()
        {
            Biom();
            Movement();
            Eat();
        }
    }

}
