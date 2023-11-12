// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter how many children in each class");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter how many children in total");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"need {num2 / num} classes");
Console.WriteLine($"and 1 class with {num2 % num} children");
