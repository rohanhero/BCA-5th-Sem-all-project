// using System;


// class UninaryOverloading{
//     private int x,y;

//     public UninaryOverloading(int x, int y){
//         this.x = x;
//         this.y = y;
//     }

//     public void showData(){
//         Console.WriteLine($"x is {x} and y is {y}");
//     }


//     // unary operator overloading
//     public static UninaryOverloading operator -(UninaryOverloading u){
//         return new UninaryOverloading(-u.x, -u.y);
//     }
// }


// public class Demo{
//     public static void Main(string[] args){
//         UninaryOverloading obj = new UninaryOverloading(2,4);

//         UninaryOverloading obj2 = -obj;
//         obj2.showData();
//     }
// }