// using System;

// class Complex
// {
//     int a, b;
//     public Complex()
//     {
//         a = 0;
//         b = 0;
//     }
//     public void setValue(int r, int i)
//     {
//         a = r;
//         b = i;
//     }

//     public void DisplayValue()
//     {
//         Console.WriteLine($"Real = {a}");
//         Console.WriteLine($"Imaginery = {b}");
//     }

//     ~Complex() //deconstructor syntax
//     {
//         Console.WriteLine("Destructor was called");
//     }

//     static void Main(string[] args)
//     {
//         Complex c = new Complex();
//         c.setValue(2, 3);
//         c.DisplayValue();
//     }
// }