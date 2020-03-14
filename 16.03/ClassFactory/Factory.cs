using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFactory
{
    partial class Factory
    {
        string Name { get; set; } = " Name";
        Department[] departments=new Department[0];
  
        partial void SetAvgSalary();
        partial void SetTotalSalary();
    }
}
