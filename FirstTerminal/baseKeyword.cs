// using System;

// public class People{
//     public int age ;
//     public string? name;

//     public People(string name, int age){
//         this.name = name;
//         this.age = age;
//     }
// }
// class Employee:People{
//     public int eid;
//     public Employee(string name, int age ,int eid) : base(name, age){
//         this.eid = eid;
//     }

//     public void display(){
//         Console.WriteLine($"The details are: {name}, {age}, {eid}");
//     }
// }

// class BaseKeywordMain{
//     public static void Main(string[] args){
//         Employee obj = new Employee("Aayush", 22, 101);
//         obj.display();
//     }
// }