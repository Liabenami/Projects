// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("enter b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("enter c");
int c = int.Parse(Console.ReadLine());
if ((a > 60 && b > 60 && c > 60) || ((a + b + c) / 3) > 80)
    Console.WriteLine("Pass");
else
    Console.WriteLine("Fail");