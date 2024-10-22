// //QUestion : Write a C# program that will read balance and withdraw amount for keyboard and display the remaining balance on screen and of balance is greater than withdraw amount otherwise throw an Application Exception with appropriate message.

// using System;

// class BankAccount
// {
//     static void Main()
//     {
//         try
//         {
//             Console.Write("Enter your current balance: ");
//             decimal balance = Convert.ToDecimal(Console.ReadLine());

//             Console.Write("Enter the amount to withdraw: ");
//             decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

//             if (withdrawAmount > balance)
//             {
//                 throw new ApplicationException("Insufficient balance for this withdrawal.");
//             }
//             else
//             {
//                 balance -= withdrawAmount;
//                 Console.WriteLine($"Withdrawal successful! Your remaining balance is: {balance:C}");
//             }
//         }
//         catch (ApplicationException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Invalid input! Please enter a valid number.");
//         }
//     }
// }
