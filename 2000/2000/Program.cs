// See https://aka.ms/new-console-template for more information using System;
Console.WriteLine("Type the number");
int NUM2 = int.Parse(Console.ReadLine());
if (NUM2 > 0)
    Console.WriteLine("POSITIVE");
else if (NUM2 < 0)
    Console.WriteLine("NEGETIVE");
else Console.WriteLine("ZERO");