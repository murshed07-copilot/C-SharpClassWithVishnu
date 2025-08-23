using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Contractor : Employee
    {
        public int HoursWorked { get; set; }

        public override int CalculateSalary(string id)
        {
            return HoursWorked * 1000;
        }
    }
}
