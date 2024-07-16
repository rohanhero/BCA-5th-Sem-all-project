// using System;

// class JaggedArrayExample
// {
//     static void Main()
//     {
//         int[][] jaggedArray = new int[][]
//         {
//             new int[] { 1, 2, 3 },
//             new int[] { 4, 5 },
//             new int[] { 6, 7, 8, 9 }
//         };

//         for (int i = 0; i < jaggedArray.Length; i++)
//         {
//             int rowSum = 0;
//             Console.Write("Row {0}: ", i);
//             for (int j = 0; j < jaggedArray[i].Length; j++)
//             {
//                 Console.Write(jaggedArray[i][j] + " ");
//                 rowSum += jaggedArray[i][j];
//             }
//             Console.WriteLine("=> Sum: " + rowSum);
//         }
//     }
// }
