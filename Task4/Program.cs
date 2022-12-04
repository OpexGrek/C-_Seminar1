// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Input A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Input B: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Input C: ");
int C = int.Parse(Console.ReadLine());

int count = 0;
int max = 0;

while (count < 3)
{
    if (A > max)
    {
        max = A;      
    }

    if (B > max)
    {
        max = B;
    }
    
    if (C > max)
    {
        max = C;
    }
    count++;
}
Console.WriteLine("Max = " + max);