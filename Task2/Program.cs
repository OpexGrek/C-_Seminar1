// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Input A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Input B: ");
int B = int.Parse(Console.ReadLine());

if (A > B)
{
    Console.WriteLine("Max = " + A);
    Console.WriteLine("Min = " + B);
}
    
if(A < B)
{
    Console.WriteLine("Max = " + B);
    Console.WriteLine("Min = " + A);
}
 
if(A == B)    
{
    Console.WriteLine("Equal numbers");
}    