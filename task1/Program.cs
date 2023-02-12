// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// напишите программу, которая на вход принимает два числа и выдает, какое больше, а какое меньше

Console.WriteLine("Input first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if (a > b)
{
    max = a;
}
else
{
   max = b;
}
Console.WriteLine("max");   
Console.WriteLine(max);    




