// using System;
// using System.Diagnostics.Contracts;


// class Employee
// {
//     public string? name;
//     public int age;

//     public Employee(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }


//     public object this[int index]
//     {
//         get
//         {
//             if (index == 0)
//             {
//                 return name;
//             }
//             else if (index == 1)
//             {
//                 return age;
//             }
//             else
//             {
//                 return null;
//             }
//         }
//     }
// }
// class Program{
//     public static void Main(string[] args){
//         Employee e = new Employee("Aayush", 22);

//         Console.WriteLine($"The name is: {e[0]}");
//         Console.WriteLine($"The age is: {e[1]}");
//     }
// }