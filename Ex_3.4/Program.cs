using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

double n = 5;
double r1 = 1;
double r2 = 3;
int count = 0;

for (int i = 1; i <= n; i++)
{
    double x, y;
    Console.WriteLine($"Введите значение X для {i} точки");
    x = double.Parse(Console.ReadLine());
    Console.WriteLine($"Введите значение Y для {i} точки");
    y = double.Parse(Console.ReadLine());

    if (((x*x + y*y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2))
    {
        count++;
    }
}
Console.WriteLine($"Количество точек: {count}");
Console.ReadLine();