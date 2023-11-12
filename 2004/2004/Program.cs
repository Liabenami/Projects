// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("enter B");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("enter C");
int C = int.Parse(Console.ReadLine());
int DOG = B * B - 4 * A * C;
if (DOG < 0)
    Console.WriteLine("No solution");
else if (DOG>0)
    Console.WriteLine("there are two solutions");
else
    Console.WriteLine("there is one solution");