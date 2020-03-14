using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03
{
    class Flash : Storage
    { 
        double Speed { get; set; } = 3.0;

        public Flash(string name, string model, double memory)
        {
            this.Name = name;
            this.Model = model;
            this.Memory = memory;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine(" Speed       : 3.0");
        }

    }
}
