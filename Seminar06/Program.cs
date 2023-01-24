// int[] num1 = {1,2,3,4,5};
// int[,] num2 = {{1,2,3},{4,5,6}};
// int[,] num3 = new int[2,3];
// for (int i=0; i<num2.GetLength(0);i++)
// {
//   for (int j=0; j<num2.GetLength(1); j++)
//   {
//     Console.Write($"{num2[i,j]} ");
//   }
//   Console.WriteLine();
// }

// Задача 39
// Написать программу, которая перевернет одномерный массив (последний
// элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1], [6 7 3 6] - [6 3 7 6]
// void PrintArray(int[] array)
// {
//   for (int i=0; i<array.Length; i++)
//   {
//     Console.Write($"{array[i]}");
//     if (i<array.Length-1) Console.Write(", ");
//     else Console.Write("");
//   }
//   Console.WriteLine("]");
// }
// int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
// Console.Write($"Initial array: [");
// PrintArray(array);
// int[] arrayRev = new int[array.Length];
// for (int i=0; i<array.Length; i++)
// {
//   arrayRev[i]=array[array.Length-1-i];
// }
// Console.Write($"Reversed array: [");
// PrintArray(arrayRev);

// Task 40
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая стороная треугольника
// меньше суммы двух других сторон.
// int[] num = new int[3];
// string result = String.Empty;
// for (int i = 0; i < num.Length; i++)
// {
//   Console.Write($"Please enter {i+1} number: ");
//   num[i] = Convert.ToInt32(Console.ReadLine());
// }
// if ((num[0] + num[1] > num[2]) && (num[1] + num[2] > num[0]) && (num[2] + num[0] > num[1])) result = "";  
//   else result = "NOT ";
// Console.WriteLine($"It is {result}possible to build the triangle with such sides");

// Задача 42
// Напишите программу, которая будет преобразовывать десятичное число
// в двоичное. 45 -> 101101, 3 -> 11, 2 -> 10
// Console.Write($"Please enter number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"The number {num} is converted to binary system as ");
// int numAdd = num;
// int degree = 1;
// while (numAdd>1)
// {
//   numAdd = numAdd / 2;
//   degree++;
// }
// int[] array = new int[degree];
// for (int i=0; i<degree; i++)
// {
//   array [degree-1-i] = num % 2;
//   num = num / 2;
// }
// for (int i=0; i<array.Length; i++) Console.Write($"{array[i]}");