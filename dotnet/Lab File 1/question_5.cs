// /*

// Create a class rectangle with properties length and width. Add a readonly property 'Area' that calculate area of rectangle using 
// length and width property. 

// */

// using System;
// using System.Diagnostics.Contracts;


// class Rectangle
// {
//     public int length;
//     public int breadth;

//     public Rectangle(int length, int breadth)
//     {
//         this.length = length;
//         this.breadth = breadth;
//     }

//     public int Area
//     {
//         get
//         {
//             return length * breadth;
//         }
//     }
// }

// class questionFour
// {
//     public static void Main(string[] args)
//     {
//         Rectangle obj = new Rectangle(4, 5);
//         Console.WriteLine($"The area is: {obj.Area}");
//     }
// }