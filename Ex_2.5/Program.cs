using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int n = 30, count = 0;
double norm = 0;

Console.WriteLine("Введите норматив (в минутах)");
norm = double.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    double answer = double.Parse(Console.ReadLine());
    if (answer >= norm)
    {
        count++;
    }
}
Console.WriteLine($"{count} спортсменов сдали норматив");