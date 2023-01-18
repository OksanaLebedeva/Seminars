Console.Clear();
Console.Write("Please enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 7 == 0) && (num % 23 == 0))
{
  Console.WriteLine("Congratulations!");
}
else
{
  Console.WriteLine("My regrets...");
}