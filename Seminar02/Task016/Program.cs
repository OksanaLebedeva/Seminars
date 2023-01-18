Console.Clear();
Console.Write("Please enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if ((num1*num1==num2) || (num2*num2==num1))
{
  Console.WriteLine("It is a win!");
}
else Console.WriteLine("It is a loss");