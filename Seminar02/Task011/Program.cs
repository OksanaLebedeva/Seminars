Console.Clear();
Console.Write("Random 3-digit number: ");
int num = new Random().Next (100,1000);
Console.WriteLine(num);
int dig1 = num / 100;
int dig2 = num % 10;
Console.Write("Result is: ");
Console.WriteLine($"{dig1}{dig2}");