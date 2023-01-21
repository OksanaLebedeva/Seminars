// void SayHello(string lang)
// {
//   Console.WriteLine($"Hello, {lang}!");
// }
// Console.WriteLine();
// SayHello("C++");
// Console.WriteLine();
// string name = "Java";
// SayHello(name);

// int SaySum (int num1, int num2)
// {
//   int sum_num=num1+num2;
//   return sum_num;
// }
// Console.Write("Please enter NUM1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter NUM2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum = {SaySum(num1, num2)}");

// Task 24
// Напишите программу, которая принимает на вход число А
// и выдает сумму чисел от 1 до А.
// 7->28, 4->10, 8->36

// int Sum(int x)
// {
//   int summa = 0;
//   for (int i=1; i<=x; i++)
//   {
//     summa = summa + i;
//   }
//   return summa;
// }
// Console.Write("Please enter Number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Sum of numbers from 1 to {num} is {Sum(num)}");

// Task 26
// Напишите программу, которая принимает на вход число и выдает
// количество цифр в числе

// int Digits (int number)
// {
//   int result = 1;
//   while (number>10)
//   {
//     number = number / 10;
//     result++;
//   }
//   return result;
// }
// Console.Write("Please enter Number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{Digits(num)} digits in entered number ({num})");

// Task 28
// Напишите программу, которая принимает на вход число А и выдает
// произведение чисел от 1 до А.
// 4->24, 5->120
// int Multiply (int number)
// {
//   int result = 1;
//   for (int i=1; i<=number; i++)
//   {
//     result = result * i;
//   }
//   return result;
// }
// Console.Write("Please enter Number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"The multiplication from 1 to {num} is {Multiply(num)}");

// Task 30
// Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке
// [1,0,1,0,0,0,1,1]
// void GenerateArray(int[] arr)
// {
//   for (int i=0; i<arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0,2);
//   }
// }
// void PrintArray(int[] array)
// {
//   Console.Write("[");
//   for (int i=0; i<array.Length; i++)
//   {
//     Console.Write($"{array[i]}");
//     if (i<array.Length-1) Console.Write(", ");
//     else Console.Write("");
//   }
//   Console.Write("]");
// }
// int[] ourarray = new int[8];
// GenerateArray(ourarray);
// PrintArray(ourarray);