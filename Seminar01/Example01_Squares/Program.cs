Console.Clear();
Console.Write("Please enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0)
{
  Console.Write("Square is: ");
  Console.WriteLine( number*number );
}
else
{
  Console.Write("The remainder of the division by 2 is: ");
  Console.WriteLine(number % 2);
}