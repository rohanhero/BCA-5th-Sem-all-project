// using System;
// class A
// {
//     private int x, y;

//     public A(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }

//     // Overloading
//     public static bool operator ==(A p1, A p2)
//     {
//         return p1.x == p2.x && p1.y == p2.y;
//     }

//     public static bool operator !=(A p1, A p2)
//     {
//         return p1.x == p2.x && p1.y == p2.y;
//     }
// }

// class Demo
// {
//     public static void Main(string[] args)
//     {
//         A p1 = new A(2, 2);
//         A p2 = new A(2, 2);
//         if (p1 == p2)
//         {
//             Console.WriteLine("It is equal.");
//         }
//         else
//         {
//             Console.WriteLine("Not equal");
//         }
//     }
// }