// using System;

// public class Program{
//     private int x;
//     private int y;

//     public Program(int x, int y) {
//         this.x = x;
//         this.y = y;
//     }

//     public void showData(){
//         Console.WriteLine($"it is {x}, {y}");
//     }

//     public static bool operator ==(Program a, Program b){
//         return a.x == b.x && a.y == b.y;

//     }
//     public static bool operator !=(Program a, Program b){
//         return a.x == b.x && a.y == b.y;

//     }



// }

// class Demo{
//     public static void Main(string[] args)
//     {
//         Program p1 = new Program(10,4);
//         Program p2 = new Program(0,4);

//         if(p1 == p2){
//             Console.WriteLine("It is equal.");
//         }else{
//             Console.WriteLine("Not equal");
//         }

//     }
// }