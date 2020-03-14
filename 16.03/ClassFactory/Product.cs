using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFactory
{ 
    class Product
    {
       string Name { get; set; }
       int Size { get; set; }
       double Prise { get; set; }

        public string ReturnString()
        {
            return " ";
        }
    }
}
