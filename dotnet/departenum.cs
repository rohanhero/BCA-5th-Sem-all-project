// using System;

// namespace EnumerationExample
// {
//     // Enumeration for Departments
//     enum Department
//     {
//         ComputerScience,
//         Electronics,
//         Mechanical,
//         Civil,
//         Electrical
//     }

//     // Enumeration for Colleges
//     enum College
//     {
//         Engineering,
//         Medical,
//         Management,
//         Law,
//         Arts
//     }

//     class Program
//     {
//         // Function to display Department enumeration
//         static void DisplayDepartments()
//         {
//             Console.WriteLine("Departments:");

//             foreach(var item in Enum.GetNames(typeof(Department))){
//                 Console.WriteLine($"- {item}");
//             }
//         }



//         // Function to display College enumeration
//         static void DisplayColleges()
//         {
//             Console.WriteLine("\nColleges:");
//             foreach (string college in Enum.GetNames(typeof(College)))
//             {
//                 Console.WriteLine("- " + college);
//             }
//         }

//         static void Main(string[] args)
//         {
//             // Display the data
//             DisplayDepartments();
//             DisplayColleges();
//         }
//     }
// }
