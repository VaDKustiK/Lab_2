using System;
using System.Net.Sockets;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int n = 999;
double sr = 0;
int neusp = 0;

double minball;
Console.WriteLine($"Введите минимальную сумму баллов за 4 экзамена");
minball = double.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Добавить студента? (Y/N)");
    string answer = Console.ReadLine();
    if (answer == "Y")
    {
        double ex1, ex2, ex3, ex4;
        Console.WriteLine($"Сколько баллов получил студент за 1 экзамен");
        ex1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Сколько баллов получил студент за 2 экзамен");
        ex2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Сколько баллов получил студент за 3 экзамен");
        ex3 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Сколько баллов получил студент за 4 экзамен");
        ex4 = double.Parse(Console.ReadLine());

        sr += ex1 + ex2 + ex3 + ex4;

        if (ex1 + ex2 + ex3 + ex4 < minball)
        {
            neusp++;
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
Console.WriteLine($"Неуспевающих: {neusp}");
Console.WriteLine($"Средний балл группы: {sr/(n*4)}");