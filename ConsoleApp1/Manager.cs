using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Manager : Employee      
    {
        public Manager() { }

        public string ManagerID { get; set; }

        public string ManagerName { get; set; }

        //aggregation - strong relationship
        public List<Employee> Employees { get; set; }

    }
}
