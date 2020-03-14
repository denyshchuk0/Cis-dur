using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFactory
{
    class Department
    {
       readonly string Name;
       public Employee[] employees=new Employee[20];
       public Department(string name)
        {
            this.Name = name;
        }
       public string ReturnString()
        {
            return " ";
        }
    }
}
