// using System;


// class Time
// {
//     public int h, m, s;

//     public Time(int h, int m, int s)
//     {
//         this.h = h;
//         this.m = m;
//         this.s = s;
//     }

//     // Overloading
//     public static Time operator +(Time t1, Time t2)
//     {
//         return new Time(t1.h + t2.h, t1.m + t2.m, t1.s + t2.h);
//     }

//     // Display
//     public void Display()
//     {
//         Console.WriteLine($"The time is: {h}: {m}: {s}");
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Time t1 = new Time(1, 2, 2);
//         Time t2 = new Time(1, 2, 2);
//         Time t3 = t1 + t2;

//         t3.Display();
//     }
// }