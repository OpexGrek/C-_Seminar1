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