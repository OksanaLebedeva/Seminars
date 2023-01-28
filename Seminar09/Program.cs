// int Factorial (int num)
// {
//     if (num == 1) return 1;
//     return num * Factorial (num - 1);
// }
// Console.Write("Please enter number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"!{x} = {Factorial(x)}");

// Задача 63. Задайте значение N. Напишите программу, которая
// выведет все натуральные числа от 1 до N.
// N=5 -> "1, 2, 3, 4, 5" N=6 -> "1, 2, 3, 4, 5, 6"
// string PrintNumber (int a)
// {
//     if (a == 1) return "1";
//     else return $"{PrintNumber(a-1)}" + $", {a}";
// } 
// Console.Write("Please enter number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Numbers between 1 and {x} = '{PrintNumber(x)}'");

// Задача 65. Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от M до N. M=1, N=5 "-> 1, 2, 3, 4, 5" 
// string PrintNumber (int a, int b)
// {
//     if (a == b) return $"{b}";
//     else return $"{a}, "+ $"{PrintNumber(a+1, b)}";
// } 
// Console.Write("Please enter number 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter number 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Numbers between {num1} and {num2} = '{PrintNumber(num1, num2)}'");

// Задача 67. Написать программу, которая будет принимать
// на вход число и возвращать сумму его цифр
// 453 -> 12
// int SumDigits (int num)
// {
//     if (num<10) return num % 10;
//     else return num %10 + SumDigits(num/10);
// }
// Console.Write("Please enter number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of its digits is: {SumDigits(num)}");

// Задача 69. Написать программу, которая на вход принимает
// два числа А и В, и возводит число А в целую степень В с помощью
// рекурсии. А=3, В=5 -> 243
// int Degree(int a, int b)
// {
//     if (b==1) return a;
//     else return a * Degree(a, b-1);
// }
// Console.Write("Please enter number 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter number 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"'{num1}' in '{num2}' degree = '{Degree(num1, num2)}'");
