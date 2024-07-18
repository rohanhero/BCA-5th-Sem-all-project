// // write a program to inherit a class Circle, Square Trangle from Base Class Shape and Calculate Area in Each Class. using System;
// using System;

// public abstract class Shape
// {
//     public abstract void Display(int value);
// }

// public class Circle : Shape
// {
//     public const double PI = 3.1415926;
//     public override void Display(int radius)
//     {
//         Console.WriteLine($"This is Circle Shape and area is: {PI * radius * radius}");
//     }
// }

// public class Square : Shape
// {
//     public override void Display(int side)
//     {
//         Console.WriteLine($"This is Square Shape and area is: {side * side}");
//     }
// }

// public class Triangle : Shape
// {
//     public override void Display(int baseValue)
//     {
//         // Console.WriteLine("Height value to calculate area of triangle.");
//         Console.Write("Enter height: ");
//         int height = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine($"This is Triangle Shape and area is: {(baseValue * height) / 2}");
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Circle c = new Circle();
//         Square s = new Square();
//         Triangle t = new Triangle();
//         c.Display(3);
//         s.Display(4);
//         t.Display(5);
//     }
// }