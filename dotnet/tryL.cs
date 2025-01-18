// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program{
//     public static void Main(string[] args){ 
//         var fruits = new List<string> {"Apple", "Mango", "Banana"};
        
//         var selectedFruits = from fruit in fruits
//                             orderby fruit descending
//                             select fruit;
                            
//         foreach(var item in selectedFruits){
//             Console.WriteLine(item);
//         }
//     }
// }