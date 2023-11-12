// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double priceless = 6.5;
double pricemore = 11.3;

Console.Write("Please enter water usage ");
double waterusage = double.Parse(Console.ReadLine());

double costlow = waterusage * priceless;
double costhigh = (waterusage - 3.4) * pricemore + (3.4 * priceless);

double totalcost = costlow;
if (waterusage > 3.4)
{
    totalcost += costhigh;
}

double end = totalcost * 0.17;
totalcost += end;
Console.WriteLine($"total water bill = {end}");
Console.WriteLine($"average price per cubed meter = {end / waterusage}");

