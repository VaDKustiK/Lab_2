using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int n = 999;
double res = 0;


for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Добавить фигуру? (Y/N)");
    string an = Console.ReadLine();
    if (an == "Y")
    {
        double r;
        Console.WriteLine("Введите значение r:");
        r = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите фигуру: квадрат (S), круг (C), треугольник (T)");
        string answer = Console.ReadLine();

        if (answer == "S")
        {
            res = r * r;
            Console.WriteLine($"Площадь квадрата равна {res}");
        }
        else if (answer == "C")
        {
            res = r * r * Math.PI;
            Console.WriteLine($"Площадь круга равна {res}");
        }
        else if (answer == "T")
        {
            res = 0.5 * r * r * (Math.Sqrt(3) / 2);
            Console.WriteLine($"Площадь равностороннего треугольника равна {res}");
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
    else if (an == "N")
    {
        break;
    }
    else
    {
        Console.WriteLine("Введите Y (да) или N (нет)");
    }
}