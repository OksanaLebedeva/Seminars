// Задача 53. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// void CreateArray(int[,] array)
// {
//   for (int i=0; i<array.GetLength(0); i++)
//   {
//     for (int j=0; j<array.GetLength(1); j++)
//     {
//       array[i,j] = new Random().Next(-100,100);
//     }
//   }
// }
// void PrintArray (int[,] arr)
// {
//   for (int i=0; i<arr.GetLength(0); i++)
//   {
//     for (int j=0; j<arr.GetLength(1); j++) 
//     {
//       Console.Write($"{arr[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }
// void ChangeFirstLastLines (int[,] arr)
// {
//     int[] temp = new int[arr.GetLength(1)];
//     for (int i=0; i<arr.GetLength(1); i++)
//     {
//         temp[i] = arr[0,i];
//         arr[0,i] = arr[arr.GetLength(0)-1,i];
//         arr[arr.GetLength(0)-1,i] = temp[i];
//     }
// }

// int[,] array = new int [3,4];
// Console.WriteLine("Array: ");
// CreateArray(array);
// PrintArray(array);
// Console.WriteLine("New array: ");
// ChangeFirstLastLines(array);
// PrintArray(array);

// Задача 55. Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

// void CreateArray(int[,] array)
// {
//   for (int i=0; i<array.GetLength(0); i++)
//   {
//     for (int j=0; j<array.GetLength(1); j++)
//     {
//       array[i,j] = new Random().Next(-100,100);
//     }
//   }
// }
// void PrintArray (int[,] arr)
// {
//   for (int i=0; i<arr.GetLength(0); i++)
//   {
//     for (int j=0; j<arr.GetLength(1); j++) 
//     {
//       Console.Write($"{arr[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }
// int[,] ChangeLinesColumns (int[,] arr)
// {
//     int[,] newArray = new int[arr.GetLength(1),arr.GetLength(0)];
//     for (int i=0; i<arr.GetLength(1); i++)
//     {
//         for (int j=0; j<arr.GetLength(0); j++)
//         newArray[i,j] = arr[j,i];
//     }
//     return newArray;
// }

// int[,] array = new int [5,7];
// Console.WriteLine("Array: ");
// CreateArray(array);
// PrintArray(array);
// Console.WriteLine("New array: ");
// PrintArray(ChangeLinesColumns(array));

