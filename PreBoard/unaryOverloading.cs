// using System;
// using System.Net.NetworkInformation;

// class Counter
// {
//     public int x;

//     public Counter(int x)
//     {
//         this.x = x;
//     }

//     // Overloading
//     public static Counter operator ++(Counter c)
//     {
//         return new Counter (c.x + 1);
//     }

//     public void display()
//     {
//         Console.WriteLine($"The value of x is: {x}");
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Counter c = new Counter(5);
//         c++;
//         c++;
//         c.display();
//     }
// }