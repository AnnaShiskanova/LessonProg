// напишете программу, которая на вход принимает число (N), 
// а на выходе показывает нечетные числа  от  1 до N

Console.WriteLine("Enter any number");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i);
}