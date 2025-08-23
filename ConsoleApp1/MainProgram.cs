// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

//string firstname = "Vishnu";
//string lastname = "Raaj";

//string fullname = firstname + " " + lastname;
//string fullname1 = string.Concat(firstname, " ", lastname);
//string fullname2 = string.Format("{0} {1} {1}", firstname, lastname);
//string fullname3 = string.Format("Hi {0}, Welcome to programming", fullname);
//string fullname4 = "Hi" + " " + fullname + ", " + "Welcome to programming";
//string fullname5 = $"Hi {fullname} Welcome to programming {firstname}";

//int lenth = fullname.Length;


//int x = 20;
//int y = 18;
//bool result = true;
//if (x > y)
//{
//    Console.WriteLine("x is greater than y");
//    result = true;
//}
//else if (x == y)
//{
//    result = false;
//}
//else if (x < y)
//{
//    result = true;
//}
//else
//{
//    result = true;
//}

// string result1 = (x > y) ? "A" : "B";

//string result2 = "";
//if(x >y)
//{
//    result2 = "A";
//}
//else
//{
//    result2 = "B";
//}

//result1 = (x > y) ? "A" : ((x == y) ? "B" : "C");

//if (x > y)
//{
//    result2 = "A";
//}
//else if (x == y)
//{
//    result2 = "B";
//}
//else
//{
//    result2 = "C";
//}

//int day = 2;
//int month = 2;
//switch (day)
//{
//    case 1: //static values, no variables
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    default:
//        Console.WriteLine("Not valid");
//        break;
//}

//if (day == month)
//{
//    Console.WriteLine("Monday");
//}
//else if (day == 2)
//{

//}
//else if (day == 3)
//{
//}
//else
//{
//    Console.WriteLine("Not valid");
//}

//Employee empObj = new Employee();
//empObj.Id = "1";
//empObj.FirstName = "Sayful";
//empObj.LastName = "Murshed";
//empObj.Gender = "M";

////methods
//int salary = empObj.CalculateSalary(empObj.Id);
//empObj.CalculateSalary(empObj.Id, empObj.FirstName);

//Employee empObj3 = new Employee() { Id = "3", FirstName = "abc", LastName = "def", Gender = "F" };

////call parameterized constructor by initializing required attributes
//Employee empObj4 = new Employee("Sayful", "Murshed");
//empObj4.Id = "4";


//Employee empObj1 = new Employee();
//empObj1.Id = "2";
//empObj1.FirstName = "Vishnu";
//empObj1.LastName = "Raaj";

////empObj5 will be available only within this scope
//using(Employee empObj5 = new Employee())
//{

//}

Employee per1 = new Employee();
per1.Id = "1";
per1.FirstName = "Vishnu";
per1.LastName = "Raaj";
per1.EmployeeType = EmployeeTypeEnum.Permanent;

try
{
    int perSalary = per1.CalculateSalary(null);
}
catch(Exception ex)
{
    Console.WriteLine(ex.StackTrace);
}
finally
{
    
}

Contractor con1 = new Contractor();
con1.EmployeeType = EmployeeTypeEnum.Contractor;
con1.FirstName = "Sayful";

con1.HoursWorked = 100;
int conSalary = con1.CalculateSalary(con1.Id);

Console.WriteLine("Enter First Name");
string fName = Console.ReadLine();
fName = fName.ToUpper();

Console.WriteLine("Enter Last Name");
string lName = Console.ReadLine();
lName = lName.ToLower();

PermanentEmployee per2 = new PermanentEmployee(fName, lName, EmployeeTypeEnum.Permanent);


Department dept1 = new Department();
dept1.ID = "1";
dept1.Name = "IT";

//Association - Department contains a list of employees
dept1.Employees = new List<Employee>();
dept1.Employees.Add(per1);
dept1.Employees.Add(con1);

//employee is assocation to one department
per2.Department = dept1;

Console.WriteLine("end");




