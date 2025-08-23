using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //access modifiers - public, internal, private
    internal class Employee : IDisposable
    {
        //properties, attributes, members

        public string Id { get; set; } = string.Empty;       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string Gender { get; set; }

        //public bool IsPermanentEmployee { get; set; }

        public EmployeeTypeEnum EmployeeType { get;set; }

        //association - basic relationship
        public Department Department { get; set; }

        public int Salary { get; set; }

        
        //constructor
        public Employee()
        {

        }

        //parameterized constructors

        //polymorphism - constructor overloading
        public Employee(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public Employee(string fName)
        {
            FirstName = fName;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        //destructor, optional
        ~Employee()
        {

        }

        //method
        //Access modifier, return type, method name, parameters

        //method overloading - same name but different signature(return type, parameters)
        //public int CalculateSalary(string id)
        //{
        //    //operations

        //    return 1000;
        //}

        public virtual int CalculateSalary(string id)
        {
            
            try
            {
                //operations
                if (id == null)
                {
                    throw new ArgumentNullException("ID cannot be null");
                }
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw;
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw;
            }

            return 1000;
        }

        public void CalculateSalary(string id, string fullName)
        {
            //operations
            
        }
    }
}
