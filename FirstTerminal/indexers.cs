// using System;

// class Indexx
// {
//     public string? name;
//     public int age;

//     public Indexx(string name, int age)
//     {
//         this.name = name;
//         this.age = age;

//     }

//     public object this[int index]{
//         get{
//             if(index == 0){
//                 return name!;
//             }
//             else if(index == 1){
//                 return age;
//             }

//             return null!;
//         }
//     }
// }


// class Demo{
//     public static void Main(string[] args){
//         Indexx obj = new Indexx("Aayush", 22);
//         Console.WriteLine($"The name is: {obj[0]}");
//         Console.WriteLine($"The age is: {obj[1]}");
//     }
// }