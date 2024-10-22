// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Employee
// {
//     public string Name { get; set; }
//     public decimal Salary { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create a list of 5 employees
//         List<Employee> employees = new List<Employee>
//         {
//             new Employee { Name = "Aayush", Salary = 50000m },
//             new Employee { Name = "Aayusha", Salary = 60000m },
//             new Employee { Name = "Aayusma", Salary = 60000m },
//         };

//         // Compute the aggregate salary
//         decimal totalSalary = employees.Sum(emp => emp.Salary);

//         // Display the total salary
//         Console.WriteLine($"Total Salary of all employees: {totalSalary:C}");

//         // Sort the employees by salary in descending order and display the records
//         var sortedEmployees = employees.OrderByDescending(emp => emp.Salary);

//         Console.WriteLine("\nEmployee records in descending order of salary:");
//         foreach (var emp in sortedEmployees)
//         {
//             Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary:C}");
//         }
//     }
// }
