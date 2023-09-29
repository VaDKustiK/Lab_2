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
        double A;
        Console.WriteLine("Введите значение A");
        A = double.Parse(Console.ReadLine());

        double B;
        Console.WriteLine("Введите значение B");
        B = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите фигуру: прямоугольник (S), кольцо (C), треугольник (T)");
        string answer = Console.ReadLine();

        if (answer == "S")
        {
            res = A * B;
            Console.WriteLine($"Площадь прямоугольника равна {res}");
        }
        else if (answer == "C")
        {
            res = Math.Abs((A * A * Math.PI) - (B * B * Math.PI));
            Console.WriteLine($"Площадь кольца равна {res}");
        }
        else if (answer == "T")
        {
            res = 0.5 * A * (Math.Sqrt(Math.Pow(B, 2) + Math.Pow(A / 2, 2)));
            Console.WriteLine($"Площадь равнобедренного треугольника равна {res}");
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