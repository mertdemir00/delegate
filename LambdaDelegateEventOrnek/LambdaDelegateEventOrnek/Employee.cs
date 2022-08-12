using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDelegateEventOrnek
{
    public class Employee
    {
        public int id { get; set; } 
        public string Name { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return string.Format("Name = {0}, Salary = {1}", Name, Salary);
        }

    }
}
