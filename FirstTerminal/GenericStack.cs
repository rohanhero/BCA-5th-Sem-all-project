// using System;
// using System.Collections.Generic;
// using System.Runtime.Serialization;


// class Demo
// {
//     public static void Main(string[] args)
//     {
//         Stack<int> stack = new Stack<int>();

//         stack.Push(2);
//         stack.Push(3);
//         stack.Push(11);
//         stack.Push(1);

//         foreach(var item in stack){
//             Console.WriteLine(item);
//         }

//         stack.Pop();
//         Console.WriteLine("After POP: ");
//         foreach(var item in stack){
//             Console.WriteLine(item);
//         }

//         Console.WriteLine($"The peeked element is {stack.Peek()}");

//         if(stack.Contains(11)){
//             Console.WriteLine("Yes it contents");
//         }
//         else{
//             Console.WriteLine("NO");
//         }
//     }
// }