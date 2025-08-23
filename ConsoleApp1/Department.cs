using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Department
    {
        public Department() { }
            
        public string Name { get; set; }

        public string ID { get; set; }

        //association - basic relationship
        public List<Employee> Employees { get; set; }
    }
}
