// напишите программу, которая на входе принимает три числа
// и выдает максимальное из этих трех

Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("max = ");
Console.WriteLine(max);