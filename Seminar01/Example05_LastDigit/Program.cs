Console.Clear();
Console.Write("Please enter 3-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<1000)
{
  if (num>99)
  {
    Console.Write("The last digit is: ");
    Console.WriteLine(num % 10);
  }
  else
  {
    Console.WriteLine("You entered incorrect number, please try again");
  }
}
else
{
  Console.WriteLine("You entered incorrect number, please try again");
}