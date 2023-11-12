// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num % 2 == 0 && num2 % 3 != 0)
    Console.WriteLine("good");
else
    Console.WriteLine("bad");

