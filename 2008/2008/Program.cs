// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
    Console.WriteLine("even");
else if (num % 2 != 0)
    Console.WriteLine("odd");
if (num % 3 == 0)
    Console.WriteLine("divides by 3");
if (num % 10 == 0)
    Console.WriteLine("divides by 10");