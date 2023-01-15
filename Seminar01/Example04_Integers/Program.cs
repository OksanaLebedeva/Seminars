Console.Clear();
Console.Write("Please enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<0)
{
  num = -num;
}
int count = -num;
while(count<=num)
{
  Console.Write(count);
  Console.Write(" ");
  count++;
}
Console.WriteLine("The end");