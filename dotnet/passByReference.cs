// using System;

// namespace SwapExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 5;
//             int b = 10;

//             Console.WriteLine($"Before Swap: a = {a}, b = {b}");
//             Swap(ref a, ref b);
//             Console.WriteLine($"After Swap: a = {a}, b = {b}");
//         }
//         static void Swap(ref int x, ref int y)
//         {
//             int temp = x;
//             x = y;
//             y = temp;
//         }
//     }
// }