// using System;
// public class Fruit
// {
//     public string? name;
//     public string? taste;
//     public string? size;


//     public Fruit(string name1, string taste1, string size1)
//     {
//         name = name1;
//         taste = taste1;
//         size = size1;
//     }

//     public virtual void eat()
//     {
//         Console.WriteLine($"Name: {name} Taste: {taste} Size: {size}");
//     }
// }


// class Apple : Fruit
// {
//     public Apple(string name1, string taste1, string size1): base(name1, taste1, size1)
//     {
//     }



//     public override void eat()
//     {
//         Console.WriteLine($"APPLE::Name: {name}, Taste: {taste}, Size: {size}");
//     }
// }

// class Orange : Fruit
// {
//     public Orange(string name1, string taste1, string size1): base(name1, taste1, size1)
//     {
//     }



//     public override void eat()
//     {
//         Console.WriteLine($"ORANGE::Name: {name}, Taste: {taste} ,Size: {size}");
//     }
// }


// class questionOne{
//     public static void Main(string[] args){
//         Apple a = new Apple("Apple", "mitho", "xll");   
//         a.eat();

//         Orange O = new Orange("Orage", "Amilo", "L");
//         O.eat();
//     }
// }