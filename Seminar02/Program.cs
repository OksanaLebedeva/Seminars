// $ - COMPILES THE STRING
// int num = 3;
// Console.Write ($"Enter the number {num+2}, lalala");

// AND
// if ((num1>7) && (num2>7)) 

// OR
//if ((num1>7) || (num2 >7))

// CASCADE CONDITIONS
// int num1 = 23;
// if (num1<7)
// {
//   Console.Write("YES1");
// }
// else if (num1<17)
// {
//   Console.Write("YES2");
// }
// else if (num1<27)
// {
//   Console.Write("YES3");
// }
// else
// {
//   Console.Write("NO");
// }

// MATH FUNCTIONS
// int num1 = -5;
// double num2 = 12.3456789;
// Console.WriteLine(Math.Abs(num1));
// Console.WriteLine(Math.Max(num1, -3));
// Console.WriteLine(Math.Pow(num1, 3));
// Console.WriteLine(Math.Round(num2,3));
// Console.WriteLine(Math.Sqrt(4));

// CYCLES. FOR - COUNTED CYCLE. WHILE - UNCOUNTED or CONDITIONAL.
int num1 = 2;
int num2 = 5;
for (int i = 1; i < 7; i++)
{
  if (i == 3 || i == 4) continue;
  Console.WriteLine(i);
}
Console.WriteLine("OK");
while (num1 < 7 && num2 > 2)
{
  Console.WriteLine($"{num1} - {num2}");
  num1 += 2;
  num2 -= 2;
}