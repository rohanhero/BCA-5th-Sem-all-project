// // // Write a program to select who lived in kathmandu and study in hetauda city college using LING.


// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Student{
//     public string? Name {get; set;}
//     public string? Address {get; set;}
//     public string? College {get; set;}
// }

// class Program{
//     public static void Main(string[] args){
//         List<Student>  student = new List<Student>{
//             new Student { Name = "Aayush", Address="Hetauda", College="hcc"},
//             new Student { Name = "Ram", Address="Kathmandu", College="hcc"},
//             new Student { Name = "Sita", Address="Pokhara", College="hsm"},
//             new Student { Name = "Hari", Address="Janakpur", College="hsm"},
//         };

//         var selectEmployee = student
//         .Where(student => student.College == "hcc" && student.Address == "Kathmandu")
//         .ToList();


//         Console.WriteLine("The selected students are: ");

//         foreach (var item in selectEmployee)
//         {
//             Console.Write($"Name:{item.Name}, Address:{item.Address}, College:{item.College}");
//         }
//     }
// }