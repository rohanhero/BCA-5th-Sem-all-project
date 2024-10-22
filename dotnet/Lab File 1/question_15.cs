// // Write a Program from Generics to implement Dictionary in C#

// using System;
// using System.Collections.Generic;

// class Demo
// {
//     public static void Main(string[] args)
//     {
//         Dictionary<int, string> dict = new Dictionary<int, string>();


//         dict.Add(1, "Aayush");
//         dict.Add(2, "Rohan");
//         dict.Add(3, "Biplop");
//         dict.Add(4, "Ramesh");

//         foreach (var item in dict)
//         {
//             Console.WriteLine(item);
//         }

//         dict.Remove(2);
//         Console.WriteLine("After Remove using key: ");
//         foreach (var item in dict)
//         {
//             Console.WriteLine(item);
//         }

//         if (dict.ContainsKey(4))
//         {
//             Console.WriteLine($"The key is presented");
//         }
//         else
//         {
//             Console.WriteLine($"The key is not presented");
//         }
//     }
// }

