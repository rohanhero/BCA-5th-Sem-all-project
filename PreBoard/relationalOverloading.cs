// using System;

// class Demo
// {
//     public int x, y;

//     public Demo(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }


//     // Overloading
//     public static bool operator ==(Demo d1, Demo d2)
//     {
//         return d1.x == d2.x && d1.y == d2.y;
//     }
//     public static bool operator !=(Demo d1, Demo d2)
//     {
//         return d1.x == d2.x && d1.y == d2.y;
//     }
// }


// class Program
// {
//     public static void Main(string[] args)
//     {
//         Demo d1 = new Demo(1,2);
//         Demo d2 = new Demo(1,2);

//         if(d1 == d2){
//             Console.WriteLine("Yes they are same");
//         }
//         else{
//             Console.WriteLine("No they are't same");
//         }
//     }
// }