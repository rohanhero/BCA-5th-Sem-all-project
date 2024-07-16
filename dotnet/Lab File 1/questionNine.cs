// using System;


// class Program
// {
//     private int hours;
//     private int minutes;
//     private int seconds;

//     public Program(int hours, int minutes, int seconds)
//     {
//         this.hours = hours;
//         this.minutes = minutes;
//         this.seconds = seconds;
//     }

//     public void display()
//     {
//         Console.WriteLine($"Time: {hours}:{minutes}:{seconds}");
//     }

//     // constructor overloading
//     public static Program operator +(Program p1, Program p2)
//     {
//         return new Program(p1.hours + p2.hours, p1.minutes + p2.minutes, p1.seconds + p2.seconds);
//     }

//     public static bool operator <(Program p1, Program p2)
//     {
//         return p1.hours < p2.hours;
//     }

//     public static bool operator >(Program p1, Program p2)
//     {
//         return p1.hours < p2.hours;
//     }

//     // constructor overloading
// }

// class q9
// {
//     public static void Main(string[] args)
//     {
//         Program p1 = new Program(1, 4, 3);
//         Program p2 = new Program(5, 44, 2);

//         Program p3 = p1 + p2;

//         p3.display();
//         if (p1 < p2)
//         {
//             Console.WriteLine("It is less hai ta");
//         }
//         else
//         {
//             Console.WriteLine("It is not less hai ta");
//         }
//     }
// }

