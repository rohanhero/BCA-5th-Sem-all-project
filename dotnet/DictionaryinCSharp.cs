// using System;
// using System.Collections.Generic;

// /*
// METHODS in Dictionary
// - Add
// - Remove (only from key)
// - ContainesKey(key)
// */

// class DictionaryinCSharp{
//     public static void Main(string[] args){
//         // Using Generic collections
//         Dictionary<int, string> dict = new Dictionary<int, string>();

//         // appending the items
//         dict.Add(11,"Ram");
//         dict.Add(12,"Sita");
//         dict.Add(13,"Hari");
//         dict.Add(14,"Shiva");
//         dict.Add(15,"Bharmha");

//         // normal printing
//         foreach(var item in dict){
//             Console.WriteLine($"The key is: {item.Key} and value is {item.Value}");
//         }

//         // after removing
//         dict.Remove(15);
//         Console.WriteLine("--------------------------------------");
//         Console.WriteLine("After Removing the item: ");
//         foreach(var item in dict){
//             Console.WriteLine($"The key is: {item.Key} and value is {item.Value}");
//         }

//         // Contains Key
//         Console.WriteLine("--------------------------------------");
//         if(dict.ContainsKey(12)){
//             Console.WriteLine($"The key is presented");
//         }
//         else{
//             Console.WriteLine($"The key is not presented");
//         }
//     }
// }