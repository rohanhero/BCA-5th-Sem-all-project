// // unary operator overloading
// class Demo
// {
//     private int x;
//     private int y;

//     public Demo(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }

//     public void showData()
//     {
//         Console.WriteLine($"x is {x} and y is {y}");
//     }


//     // Operator Overloading
//     public static Demo operator -(Demo d1)
//     {
//         return new Demo(-d1.x, -d1.y);
//     }
// }


// class operatorOverloading
// {
//     public static void Main(string[] args)
//     {
//         Demo d1 = new Demo(20, 30);
//         Demo d2 = -d1;
//         // normal return
//         d1.showData();

//         // constructor overload return
//         d2.showData();
//     }
// }