using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

double n = 999;
int count = 0;

double r1 = 1;
double r2 = 3;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Добавить точку? (Y/N)");
    string answer = Console.ReadLine();
    if (answer == "Y")
    {
        double x, y;
        Console.WriteLine($"Введите значение X");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine($"Введите значение Y");
        y = double.Parse(Console.ReadLine());

        if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2))
        {
            count++;
        }
    }
    else if (answer == "N")
    {
        break;
    }
    else
    {
        Console.WriteLine("Введите Y (да) или N (нет)");
    }
}
Console.WriteLine($"Количество точек: {count}");