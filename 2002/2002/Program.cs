// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int NUM1 = int.Parse(Console.ReadLine());
int NUM2 = int.Parse(Console.ReadLine());
if (NUM1 == NUM2)
    Console.WriteLine("double");
else if (NUM1 == 5 && NUM2 == 6)
    Console.WriteLine("Sheshbesh");
else if (NUM1 == 6 && NUM2 == 5)
    Console.WriteLine("Sheshbesh");
else
    Console.WriteLine("regular");
