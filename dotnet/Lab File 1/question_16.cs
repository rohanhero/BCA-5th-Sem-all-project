// // Question : WAP to check the college name and throw the exception if the name of the college is above 50 characters.

// using System;


// class Demo
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             Console.WriteLine("Enter your college name: ");
//             string? collegeName = Console.ReadLine();

//             if (collegeName.Length > 50)
//             {
//                 throw new ApplicationException("College name should below 50 chars");
//             }
//             Console.WriteLine($"College Name: {collegeName}");
//         }
//         catch(Exception e){
//             Console.WriteLine(e);
//         }
//     }
// }