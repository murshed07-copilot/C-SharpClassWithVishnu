using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //child class or dervied class
    internal class PermanentEmployee : Employee //parent or base class
    {

        public PermanentEmployee()
        {
            
        }

        //composition
        public SalaryStructure SalaryStructure { get; set; }

        public PermanentEmployee(string firstName, string lastName, EmployeeTypeEnum type) : base (firstName, lastName)
        {
            this.EmployeeType = type;                
        }

        //method overriding
        public override int CalculateSalary(string id)
        {
            return 2000;
        }
    }
}
