using System;
using System.ComponentModel.Design;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double x, y;
Console.WriteLine("Введите значение X");
x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y");
y = double.Parse(Console.ReadLine());

if (y >= 0 && y + Math.Abs(x) <= 1)
{
    Console.WriteLine("Точка лежит внутри фигуры");
}
else
{
    Console.WriteLine("Точка не лежит внутри фигуры");
}