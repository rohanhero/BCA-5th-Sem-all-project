// // Multi Cast Delegate
// using System;
// public delegate int Mathdelegate(int x, int y);


// class Calculator
// {
//     public int sum(int x, int y)
//     {
//         return x + y;
//     } 

//     public int diff(int x, int y)
//     {
//         return x - y;
//     }
// }


// class Demo
// {
//     public static void Main(string[] args)
//     {
//         Calculator c = new Calculator();
//         Mathdelegate d = c.sum;
//         d += c.sum;
//         int mainres = d(4,4); 
//         Console.WriteLine($"The result is: {mainres}");
//     }
// }
