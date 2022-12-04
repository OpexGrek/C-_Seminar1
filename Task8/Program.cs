// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Input N: ");
int N = int.Parse(Console.ReadLine());
int N0 = 1;
int A = Math.Abs(N % 2);

if (N == 1)
    Console.Write("There is no even numbers");

if (N < 1)
    Console.Write("You can input only integer");

while (N0 < N)
{
    if (A == 0)
            Console.Write(N0 + 1 + " ");
    else
    {
        Console.Write(N0 + 1 + " ");
        if (N0 == N)
        {
            Console.Write(N0 + " ");
        }
    }
    N0 = N0 + 2;
}