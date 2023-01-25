// Задача 46. Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами.
// m=3, n=4
// void CreateArray(int[,] array, int m, int n)
// {
//   for (int i=0; i<m; i++)
//   {
//     for (int j=0; j<n; j++)
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
// int[,] array = new int [3,4];
// Console.WriteLine("Array: ");
// CreateArray(array, array.GetLength(0), array.GetLength(1));
// PrintArray(array);

// Задача 48. Задайте двумерный массив размера m на n, каждый
// элемент в массиве на ходится по формуле Amn=m+n;
// Выведите полученный массив на экран (3,4)
// void CreateArray(int[,] array, int m, int n)
// {
//   for (int i=0; i<m; i++)
//   {
//     for (int j=0; j<n; j++)
//     {
//       array[i,j] = i+j;
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
// int[,] array = new int [6,7];
// Console.WriteLine("Array: ");
// CreateArray(array, array.GetLength(0), array.GetLength(1));
// PrintArray(array);

// Задача 49. Задайте двумерный массив. Найдите элементы,
// у которых оба индекса четные, и замените эти элементы
// на их квадраты
// void CreateArray(int[,] arr, int m, int n)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       arr[i, j] = new Random().Next(0, 10);
//     }
//   }
// }
// void PrintArray(int[,] arr)
// {
//   for (int i = 0; i < arr.GetLength(0); i++)
//   {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       Console.Write($"{arr[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }
// void ReplaceArray(int[,] arr)
// {
//   for (int i = 0; i < arr.GetLength(0); i++)
//   {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       if ((i % 2 == 0) && (j % 2 == 0)) arr[i, j] = arr[i, j] * arr[i, j];
//     }
//   }
// }
// int[,] array = new int[6, 7];
// Console.WriteLine("Initial array: ");
// CreateArray(array, array.GetLength(0), array.GetLength(1));
// PrintArray(array);
// Console.WriteLine("Changed array: ");
// ReplaceArray(array);
// PrintArray(array);

// Задача 51. Задайте двумерный массив. Найдите сумму элементов,
// стоящих на главной диагонали (с равными индексами)
// void CreateArray(int[,] arr, int m, int n)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       arr[i, j] = new Random().Next(0, 10);
//     }
//   }
// }
// void PrintArray(int[,] arr)
// {
//   for (int i = 0; i < arr.GetLength(0); i++)
//   {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       if (i==j) Console.ForegroundColor = ConsoleColor.Blue;
//       Console.Write($"{arr[i, j]} ");
//       Console.ForegroundColor = ConsoleColor.White;
//     }
//     Console.WriteLine();
//   }
// }
// int SumDiagonal(int[,] arr)
// {
//   int sum =0;
//   for (int i = 0; i < arr.GetLength(0); i++)
//   {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       if (i==j) sum = sum + arr[i,j];
//     }
//   }
//   return sum;
// }
// int[,] array = new int[6, 7];
// Console.WriteLine("Initial array: ");
// CreateArray(array, array.GetLength(0), array.GetLength(1));
// PrintArray(array);
// Console.WriteLine($"Sum of elements on main diagonal is {SumDiagonal(array)}");

// x1^5+x2^5+x3^5+x4^5=x5^5

// Console.WriteLine("Start"); ????
// for (int i=1; i<300; i++)
// {
//   for (int j=1; j<300; j++)
//   {
//     for (int k=1; k<300; k++)
//     {
//       for (int l=1; l<300; l++)
//       {
//         for (int m=1; m<300; m++)
//         {
//           if (Math.Pow(i,5)+Math.Pow(j,5)+Math.Pow(k,5)+Math.Pow(l,5) == Math.Pow(m,5)) Console.WriteLine($"{i} {j} {k} {l} {m}");
//         }
//       }
//     }
//   }
// }
// Console.WriteLine("Finish");