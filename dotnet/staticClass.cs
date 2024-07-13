// /*
// - static means something which cannot be instantiated
// - static class containg only static member
// - we cannot create object of static class
// - we cannot access static member using an object
// - static member are accessed by the classname followed by the member name 
// */


// using System;
// static class staticClass
// {
//     static public int age;
//     static public string? name;

//     public static void Display(){
//         Console.WriteLine($"Age: {age} and Name: {name}");
//     }
// }


// class mainClassofStatic{
//     static void Main(string[] args){
//         staticClass.age = 20;
//         staticClass.name = "Ram";
//         staticClass.Display();
//     }
// }