// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Employee{
//     public string? Name{get; set;}
//     public int Age{get; set;}
//     public string? Address{get; set;}
// }

// class Program{
//     public static void Main(string[] args){
//         List<Employee> employee = new List<Employee>{
//             new Employee {Name ="A", Age=18, Address="Hetauda"},
//             new Employee {Name ="B", Age=21, Address="Kathmandu"},
//             new Employee {Name ="C", Age=32, Address="Hetauda"},
//             new Employee {Name ="D", Age=26, Address="Kathmandu"}
//         };
        
//         var selectedEmployee = from emp in employee
//                                 where emp.Age > 25 && emp.Address == "Kathmandu"
//                                 select emp;


//         // var selectedEmployee = employee.Where(employee => employee.Age>25 &&
//         // employee.Address == "Kathmandu").ToList();
        
//         foreach(var item in selectedEmployee){
//             Console.WriteLine(item.Name);
//         }
//     }
// }