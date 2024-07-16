// using System;

// class Program
// {
//     private int x;
//     private int y;

//     public Program(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }

//     public void showData()
//     {
//         Console.WriteLine($"Feet is: {x} and Inch is: {y}");
//     }

//     // binary constructor overloading
//     public static Program operator +(Program p1, Program p2)
//     {
//         int f = p1.x + p2.x;
//         int i = p1.y + p2.y;
//         return new Program(f, i);
//     }
// }



// class binaryConstructorOverloading
// {
//     public static void Main(string[] args)
//     {
//         Program p1 = new Program(10, 4);
//         Program p2 = new Program(9, 9);

//         Program p3 = p1 + p2;

//         p3.showData();
//     }
// }