// // Question: Write a Program to Implement singlecast delegate
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
//         Mathdelegate m_sum = new Mathdelegate(c.sum);
//         Mathdelegate m_diff = new Mathdelegate(c.diff);

//         int res1 = m_sum(4, 4);
//         int res2 = m_diff(8, 4);

//         Console.WriteLine($"The sum is: {res1}");
//         Console.WriteLine($"The difference is: {res2}");
//     }
// }
