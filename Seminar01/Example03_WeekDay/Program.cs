Console.Clear();
Console.Write("Please enter the number from 1 to 7: ");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday==1) {Console.WriteLine("It's Monday");}  
if (weekday==2) {Console.WriteLine("It's Tuesday");}
if (weekday==3) {Console.WriteLine("It's Wednesday");}
if (weekday==4) {Console.WriteLine("It's Thursday");}
if (weekday==5) {Console.WriteLine("It's Friday");}
if (weekday==6) {Console.WriteLine("It's Saturday");}
if (weekday==7) {Console.WriteLine("It's Sunday");}
if (weekday<1) {Console.WriteLine("You entered wrong number, bye");}
if (weekday>7) {Console.WriteLine("You entered wrong number, bye");}