using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double x, y;
Console.WriteLine("Введите значение X");
x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y");
y = double.Parse(Console.ReadLine());

double r = 2;

if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) <= Math.Pow(10, -3))
{
    Console.WriteLine($"Точка лежит на окружности с радиусом {r}");
}
else
{
    Console.WriteLine($"Точка не лежит на окружности с радиусом {r}");
}