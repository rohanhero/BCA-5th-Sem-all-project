// /*
// Question:
// Create a class bank account with properties account no and balance. Ensure that the balance property
// can't be set to a negative value if an attempt is made to set a negative value, it should leave
// the balance unchanged and print an error message.

// */


// using System;

// class Bank
// {
//     private int balance;

//     //This is the properties start
//     public int Balance
//     {
//         get
//         {
//             return balance;
//         }
//         set
//         {
//             balance = value;
//         }
//     }
//     //This is the properties ends
// }


// class questionThree
// {
//     public static void Main(string[] args)
//     {
//         Bank obj = new Bank();
//         obj.Balance = -3000;
//         try
//         {
//             if (obj.Balance < 0)
//             {
//                 Console.WriteLine("Error! The value is negative");
//             }
//             else
//             {
//                 Console.WriteLine(obj.Balance);
//             }
//         }
//         catch (System.Exception)
//         {

//             throw;
//         }
//     }
// }