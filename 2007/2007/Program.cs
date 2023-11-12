// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if ((a == b) && (a != c))
    Console.WriteLine("isosceles");
else if ((a == b) && (a == c))
    Console.WriteLine("equilateral");
else
    Console.WriteLine("scalene");
