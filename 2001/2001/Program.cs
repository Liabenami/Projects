// See https://aka.ms/new-console-template for more information
Console.WriteLine("please enter A,B,C ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
if (A + B + C == 180)
    Console.WriteLine("possible is triangle A");
else
    Console.WriteLine("A triangle is not possible");
