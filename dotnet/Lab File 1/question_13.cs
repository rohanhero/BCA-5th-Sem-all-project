// // Write a Program to show the implementation of Queue in C#

// using System;
// using System.Collections.Generic;
// class Demo{
//     public static void Main(string[] args){
//         Queue<int> queue = new Queue<int>();


//         queue.Enqueue(1);
//         queue.Enqueue(11);
//         queue.Enqueue(32);
//         queue.Enqueue(65);

//         foreach(var item in queue){
//             Console.WriteLine(item);
//         }


//         queue.Dequeue();
//         Console.WriteLine("After one dequeue: ");
//         foreach(var item in queue){
//             Console.WriteLine(item);
//         }

//         Console.WriteLine($"The peeked item is: {queue.Peek()}");

//         if(queue.Contains(32)){
//             Console.WriteLine("Yes");
//         }

//         else{
//             Console.WriteLine("NO");
//         }
//     }
// }