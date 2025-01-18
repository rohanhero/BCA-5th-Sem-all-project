// using System;

// class People{
//     protected string? name; 
//     protected int age;

//     public People(string name, int age){
//         this.name = name;
//         this.age = age;
//     }
// }


// class Employee:People{
//     long salary;

//     public Employee(string name, int age, long salary): base(name, age){
//         this.salary = salary;
//     }

//     public void display(){
//         Console.WriteLine($"Name: {name}, age: {age}, salary: {salary}");
//     }
// }

// class Demo{
//     public static void Main(string[] args){
//         Employee e = new Employee("Aayush", 22, 30000);
//         e.display();
//     }
// }