// /* 
// - Write a program to demonstrate static constructor
// - Write a program to implement indexer in C #
// - Write a program to implement properties in C#
// */

// using System;
// using System.Collections.Generic;

// // static constructor
// class Person
// {
//     static Person()
//     {
//         Console.WriteLine("This is the static constructor");
//     }
// }

// // indexer
// class indexTest
// {
//     int id;
//     string? name;
//     string? address;
//     int salary;
//     int age;

//     public indexTest(int id, string name, string address, int salary, int age)
//     {
//         this.id = id;
//         this.name = name;
//         this.address = address;
//         this.salary = salary;
//         this.age = age;
//     }

//     public object this[int index]
//     {
//         get
//         {
//             if (index == 0)
//             {
//                 return id;
//             }
//             else if (index == 1)
//             {
                
//                 return name != null;
//             }
//             else if (index == 2)
//             {
//                 return address != null;;
//             }
//             else if (index == 3)
//             {
//                 return salary;
//             }
//             else if (index == 4)
//             {
//                 return age;
//             }
//             return null != null;
//         }
//     }
//     // idexer ends
// }


// class testProperties{
//     int age;

//     public int Age{
//         get{
//             return age;
//         }
//         set{
//             age = value;
//         }
//     }
// }



// class question_16
// {
//     static void Main(string[] args)
//     {
//         // Object for person
//         //- Write a program to demonstrate static constructor
//         Person person = new Person();


//         // object for  indexer
//         // - Write a program to implement indexer in C #
//         indexTest indexer = new indexTest(1, "Sandip", "Hetauda-5", 3000, 22);
//         Console.WriteLine("Age is: " + indexer[4]);

//         // object for properties
//         //- Write a program to implement properties in C#
//         testProperties testProperties = new testProperties();
//         testProperties.Age = 32;
//         Console.WriteLine($"The age is: {testProperties.Age}");
//     }
// }