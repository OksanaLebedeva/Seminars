Console.Clear();
Console.Write("Please enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int ost = num1 % num2;
if (ost == 0)
{
  Console.WriteLine("YESSSS!");
}
else
{
  Console.WriteLine(ost);
}