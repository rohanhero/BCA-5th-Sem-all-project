// using System;
// using System.Collections.Generic;

// class Book
// {
//     public string? title;
//     public string? author;
//     public string? isbn;

//     public string? Title
//     {
//         get
//         {
//             return title;
//         }
//         set
//         {
//             title = value;
//         }
//     }

//     public string? Author
//     {
//         get
//         {
//             return author;
//         }
//         set
//         {
//             author = value;
//         }
//     }


//     public string? ISBN
//     {
//         get
//         {
//             return isbn;
//         }
//         set
//         {
//             isbn = value;
//         }
//     }
// }

// class question_11
// {
//     public static void Main(string[] args)
//     {
//         Queue<Book> bookQueue = new Queue<Book>();

//         Book obj = new Book(); 

//         obj.Title = "Dotnet";
//         obj.Author = "Ram Mainali";
//         obj.ISBN = "304";

//         Console.WriteLine($"The book name is: {obj.Title}");
//         Console.WriteLine($"The book author is: {obj.Author}");
//         Console.WriteLine($"The book isbn is: {obj.ISBN}");


//         bookQueue.Enqueue(obj);

//         Book dequeuedBook = bookQueue.Dequeue();
//         Console.WriteLine("Dequeued book details:");
//         Console.WriteLine($"The book name is: {dequeuedBook.Title}");
//         Console.WriteLine($"The book author is: {dequeuedBook.Author}");
//         Console.WriteLine($"The book isbn is: {dequeuedBook.ISBN}");
//     }
// }
