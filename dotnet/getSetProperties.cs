// /*
// +====================================================================================================+
// |Definition:                                                                                         |
// |- Private variable can only be accessed within the same class (outside class has no access to it).  |
// |- Sometime we need to access them and it can be done with properties.                               |
// |- Properties is like a combination of variable and method and it has two method get, set.           |
// +====================================================================================================+
// */

// /*
// +=============================================================+
// |Types of properties in C#:                                   |    
// |- Read, Write (Accessors) = get,set                          |
// |- Read, Only (Accessors) = get                               |
// |- Write, Only (Accessors) = set                              |
// |- Auto Implemented (Accessors) = without implementation      |
// +=============================================================+
// */

// using System;

// class Demo
// {
//     private int age;

//     //This is the properties start
//     public int Age    
//     {
//         get{
//             return age;
//         }
//         set{
//             age = value;
//         }
//     }
//     //This is the properties ends
// }


// class getSetProperties{
//     public static void Main(string[] args){
//         Demo obj = new Demo();
//         obj.Age = 30;  //set
//         Console.WriteLine(obj.Age);  //get
//     }
// }