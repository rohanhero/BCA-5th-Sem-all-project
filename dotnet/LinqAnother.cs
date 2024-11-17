// /*WAP in C# to select employee whose salary is greater
// than 20000 and those adress is kathmandu using LINQ*/


// using System;
// using System.Collections.Generic;
// using System.Linq;


// class Employee{
//     public string? Name {get; set;}
//     public int Salary {get; set;}
//     public string? Address {get; set;} 
// }


// class Program{
//     public static void Main(string[] args){
//         List<Employee> employee =  new List<Employee>{
//             new Employee{Name="Aayush",Salary=30000, Address="kathmandu" },
//             new Employee{Name="Rohan",Salary=50000, Address="hetauda" },
//             new Employee{Name="LilJhola",Salary=10000, Address="pokhara" }
//         };



//         // Linq
//         var selectedemployee = employee.Where(employee=>employee.Salary >=20000 && employee.Address == "kathmandu")
//         .ToList();

//         foreach(var item in selectedemployee){
//             Console.WriteLine($"{item.Name}");
//         }
//     }
// }