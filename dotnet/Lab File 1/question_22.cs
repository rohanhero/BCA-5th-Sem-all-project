// //Question: Write a program to implement predicate delegate from generic delegate.
// using System;

// class Demo
// {
//     static bool IsUpperCase(string mystr)
//     {
//         return mystr == mystr.ToUpper();
//     }

//     static void Main(String[] args)
//     {
//         Predicate<string> isUpper = IsUpperCase;
//         bool result = isUpper("UPPER CHECK");
//         Console.WriteLine(result);
//     }
// }
