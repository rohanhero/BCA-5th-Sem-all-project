// /* Question: WAP in C# to select employee whose salary is greater
// than 20000 and those adress is kathmandu using LINQ (Note : This code doesn't run in online compilers)*/


// using System;

// using System.Linq;

// class Employee{
//     public string? Name {get; set;}
//     public int Salary {get; set;}
//     public string? Address {get; set;}
// }

// class Program{
//     public static void Main(string[] args){
//         List<Employee> employee = new List<Employee>{
//             new Employee {Name = "Aayush", Salary=30000, Address="Hetauda"},
//             new Employee {Name = "Rohit", Salary=60000, Address="Pokhara"},
//             new Employee {Name = "Ram", Salary=70000, Address="Kathmandu"},
//             new Employee {Name = "Sita", Salary=65000, Address="Kathmandu"},
//         };


//         // LINQ
//         var selectEmployee = employee
//         .Where(employee => employee.Salary > 20000 && employee.Address == "Kathmandu")
//         .ToList();


//         Console.WriteLine("The employee whose salary is greater than 20000 and address is Kathamndu is: ");

//         foreach(var item in selectEmployee){
//             Console.WriteLine($"The name is: {item.Name},Salary: {item.Salary},Address: {item.Address}");
//         }
//     }
// }