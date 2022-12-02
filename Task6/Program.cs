Console.Write("Input A: ");
int A = int.Parse(Console.ReadLine());

int B = Math.Abs(A % 2); // Превращаем отрицательный остаток в положительный

if (B == 1)
{
    Console.WriteLine("Number " + A + " is odd");
}
else
{
    Console.WriteLine("Number " + A + " is even");
}