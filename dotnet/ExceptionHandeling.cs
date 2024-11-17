// using System;
// class Demo
// {
//     public static void Main(string[] args)
//     {
//         int a=2,b=2;
//         try
//         {
//             int result = a/b;
//             Console.WriteLine($"The result is {result}");
//         }
//         // catch(Exception e)
//         // {
//         //     Console.WriteLine(e);
//         // }

//         // Using custom message (throw)
//         catch(System.Exception)
//         {
//             throw new ArithmeticException("Trying to divide by zero");
//         }
//     }
// }