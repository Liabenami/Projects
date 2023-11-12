// See https://aka.ms/new-console-template for more information
Console.WriteLine("please enter you're grade");
int grade = int.Parse(Console.ReadLine());
char letter;

if (grade < 0 || grade > 100) // לא תקין
{
    Console.WriteLine("illegal grade");
    letter = 'X';
}
else if (grade >= 90)
    letter = 'A';
else if (grade >= 80 && grade < 90)
    letter = 'B';
else if (grade >= 70 && grade < 80)
    letter = 'C';
else if (grade >= 60 && grade < 70)
    letter = 'D';
else
    letter = 'F';

Console.WriteLine(letter);

