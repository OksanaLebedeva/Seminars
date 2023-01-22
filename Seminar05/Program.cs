// Задача 31
// Задайте массив из 12 элементов, заполненный случайным
// числами из промежутка [-9;9], найдите сумму отрицательных
// и положительных чисел

// void GenerateArray(int[] arr)
// {
//   for (int i=0; i<arr.Length; i++)
//   {
//     arr[i] = new Random().Next(-9,10);
//   }
// }
// void PrintArray(int[] array)
// {
//   Console.Write($"Our array: [");
//   for (int i=0; i<array.Length; i++)
//   {
//     Console.Write($"{array[i]}");
//     if (i<array.Length-1) Console.Write(", ");
//     else Console.Write("");
//   }
//   Console.WriteLine("]");
// }
// int SumPositiveElements(int[] array)
// {
//   int resultPos = 0;
//   for (int i=0; i<12; i++)
//   {
//     if (array[i]>0) resultPos = resultPos + array[i];
//   }
//   return resultPos;
// }
// int SumNegativeElements(int[] array)
// {
//   int resultNeg = 0;
//   for (int i=0; i<12; i++)
//   {
//     if (array[i]<0) resultNeg = resultNeg + array[i];
//   }
//   return resultNeg;
// }

// int[] ourarray = new int[12];
// GenerateArray(ourarray);
// PrintArray(ourarray);
// Console.WriteLine($"Sum of negative elements is: {SumNegativeElements(ourarray)}");
// Console.WriteLine($"Sum of positive elements is: {SumPositiveElements(ourarray)}");

// Задача 32
// Напишите программу замены элементов массива: положительные элементы замените
// на соответствующие отрицательные [-4;-8;8;2] -> [4;8;-8;2]
// void GenerateArray(int[] arr)
// {
//   for (int i=0; i<arr.Length; i++)
//   {
//     arr[i] = new Random().Next(-9,10);
//   }
// }
// void PrintArray(int[] array)
// {
//   Console.Write($"Our array: [");
//   for (int i=0; i<array.Length; i++)
//   {
//     Console.Write($"{array[i]}");
//     if (i<array.Length-1) Console.Write(", ");
//     else Console.Write("");
//   }
//   Console.WriteLine("]");
// }
// void ChangeNegativePositive(int[] array)
// {
//   for (int i=0; i<array.Length; i++)
//   {
//     array[i]=-array[i];
//   }
// }
// int[] ourarray = new int[10];
// GenerateArray(ourarray);
// PrintArray(ourarray);
// ChangeNegativePositive(ourarray);
// PrintArray(ourarray);

// Задача 33
// Задайте массив, напишите программу, которая определяет, присутствует ли заданное число
// в массиве. 4; массив [6,7,19,345,3] -> нет. -3 -> да.
// void GenerateArray(int[] arr)
// {
//   for (int i=0; i<arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0,100);
//   }
// }
// void PrintArray(int[] array)
// {
//   Console.Write($"Our array: [");
//   for (int i=0; i<array.Length; i++)
//   {
//     Console.Write($"{array[i]}");
//     if (i<array.Length-1) Console.Write(", ");
//     else Console.Write("");
//   }
//   Console.WriteLine("]");
// }
// int CheckInArray(int number, int[] array)
// {
//   int amount = 0;
//   for (int i=0; i<array.Length; i++)
//   {
//     if (array[i]==number) amount++;
//   }
//   return (amount);
// }
// Console.Write("Please enter the number to check in array: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] ourarray = new int[10];
// GenerateArray(ourarray);
// PrintArray(ourarray);
// if (CheckInArray(num, ourarray)>0) Console.WriteLine("Yes, this number is in the array");
// else Console.WriteLine("No, this number is NOT in the array");

// Задача 35
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]
// void GenerateArray(int[] arr)
// {
//   for (int i=0; i<arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0,1000);
//   }
// }
// void PrintArray(int[] array)
// {
//   Console.Write($"Our array: [");
//   for (int i=0; i<array.Length; i++)
//   {
//     Console.Write($"{array[i]}");
//     if (i<array.Length-1) Console.Write(", ");
//     else Console.Write("");
//   }
//   Console.WriteLine("]");
// }
// int CheckSegmentInArray(int[] array)
// {
//   int amount = 0;
//   for (int i=0; i<array.Length; i++)
//   {
//     if (array[i]<100 && array[i]>9) amount++;
//   }
//   return (amount);
// }
// int[] ourarray = new int[123];
// GenerateArray(ourarray);
// PrintArray(ourarray);
// Console.WriteLine($"There are {CheckSegmentInArray(ourarray)} numbers in segment [10,99]");

// Задача 37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве. 
// void GenerateArray(int[] arr)
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0, 10);
//   }
// }
// void PrintArray(int[] array)
// {
//   Console.Write($"Our array: [");
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write($"{array[i]}");
//     if (i < array.Length - 1) Console.Write(", ");
//     else Console.Write("");
//   }
//   Console.WriteLine("]");
// }
// void MultiplyPairs(int[] arrayIn, int[] arrayOut)
// {
//   for (int i = 0; i < arrayIn.Length / 2; i++)
//   {
//     arrayOut[i] = arrayIn[i] * arrayIn[arrayIn.Length - 1 - i];
//     Console.WriteLine($"{arrayIn[i]} x {arrayIn[arrayIn.Length - 1 - i]} = {arrayOut[i]}");
//   }
//   if (arrayIn.Length % 2 == 1)
//   {
//     arrayOut[arrayOut.Length - 1] = arrayIn[arrayOut.Length - 1];
//     Console.WriteLine(arrayOut[arrayOut.Length - 1]);
//   }
// }

// int[] ourArray = new int[21];
// GenerateArray(ourArray);
// PrintArray(ourArray);

// int lengthNewArray;
// if (ourArray.Length % 2 == 0) lengthNewArray = ourArray.Length / 2;
// else lengthNewArray = ourArray.Length / 2 + 1;
// int[] newArray = new int[lengthNewArray];

// MultiplyPairs(ourArray, newArray);
// PrintArray(newArray);