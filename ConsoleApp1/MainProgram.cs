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

/*
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

*/

Department department1 = new Department()
{
    ID = "1",
    Name = "IT"
};

Department department2 = new Department()
{
    ID = "2",
    Name = "HR"
};

Department department3 = new Department()
{
    ID = "3",
    Name = "Finance"
};

Employee employee1 = new Employee()
{
    Id = "1",
    FirstName = "A",
    LastName = "AA",
    Gender = "M",
    EmployeeType = EmployeeTypeEnum.Contractor,
    Department = department1,
    Salary = 1000
};

Employee employee2 = new Employee()
{
    Id = "2",
    FirstName = "B",
    LastName = "BB",
    Gender = "F",
    EmployeeType = EmployeeTypeEnum.Permanent,
    Department = department2,
    Salary = 1000
};


Employee employee3 = new Employee()
{
    Id = "3",
    FirstName = "C",
    LastName = "CC",
    Gender = "M",
    EmployeeType = EmployeeTypeEnum.Contractor,
    Department = department3,
    Salary = 1000
};


Employee employee4 = new Employee()
{
    Id = "4",
    FirstName = "D",
    LastName = "DD",
    Gender = "F",
    EmployeeType = EmployeeTypeEnum.Permanent,
    Department = department1,
    Salary = 1400
};


Employee employee5 = new Employee()
{
    Id = "5",
    FirstName = "E",
    LastName = "EE",
    Gender = "M",
    EmployeeType = EmployeeTypeEnum.Contractor,
    Department = department1,
    Salary = 1000
};


Employee employee6 = new Employee()
{
    Id = "6",
    FirstName = "F",
    LastName = "FF",
    Gender = "M",
    EmployeeType = EmployeeTypeEnum.Contractor,
    Department = department2,
    Salary = 3000
};

List<Employee> employeeList = new List<Employee>();
employeeList.Add(employee1);
employeeList.Add(employee2);
employeeList.Add(employee3);
employeeList.Add(employee4);
employeeList.Add(employee5);
employeeList.Add(employee6);

//where - all objects
List<Employee> femaleEmployees = employeeList.Where(emp => emp.Gender == "F").ToList();

//select
List<string> names = new List<string>();
foreach (var item in employeeList)
{
    names.Add(item.FullName);
}

names = employeeList.Select(emp => emp.FullName).ToList();


//first - 1st female employee = throw exception if no matching records
Employee firstFemale = employeeList.First(emp => emp.Gender == "F");

List<Employee> femaleEmployees1 = employeeList.Where(emp => emp.Gender == "F").ToList();
Employee firstFemale1 = femaleEmployees1[0];

//second, third etc.,

//firstordefault => return null if not matching
Employee firstFemale2 = employeeList.FirstOrDefault(emp => emp.Gender == "F");

//order
List<Employee> orderedList = employeeList.OrderBy(emp => emp.FullName).ToList(); //ascending
List<Employee> orderedList1 = employeeList.OrderByDescending(emp => emp.FullName).ToList();

//order by descending using full name and then retrive only the full name, not entire object
List<string> namesList = employeeList.OrderByDescending(emp => emp.FullName).Select(emp => emp.FullName).ToList();


//any - true if one object satisfy the condition
bool hasFemaleEmployee = employeeList.Any(emp => emp.Gender == "F");

//all - true only if all objects satisfy the condition
bool isAllFemale = employeeList.All(emp => emp.Gender == "F");

//
bool hasFemaleEmployee1 = employeeList.Any(emp => emp.Gender == "F" && emp.Id == "2");

//mathematical
//count, sum, average
int allEmployeesCount = employeeList.Count();
int maleEmployeesCount = employeeList.Count(emp => emp.Gender == "M");
int totalSalary = employeeList.Sum(emp => emp.Salary);
int totalMaleSalary = employeeList.Where(emp => emp.Gender == "M").Sum(emp => emp.Salary);
double averageSalary = employeeList.Average(emp => emp.Salary);
//max, min


Console.WriteLine("end");




