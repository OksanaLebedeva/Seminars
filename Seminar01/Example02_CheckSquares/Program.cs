Console.Clear();
Console.Write("Please enter first number: ");
int square = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter second number: ");
int root = Convert.ToInt32(Console.ReadLine());
if (square==root*root)
{
  Console.WriteLine("First number is a square of the second number!");
}
else
{
  Console.WriteLine("Unfortunately, first number is NOT a square of the second number");
}