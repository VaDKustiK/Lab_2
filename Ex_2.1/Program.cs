using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int n;
Console.WriteLine("Сколько человек в классе?");
n = int.Parse(Console.ReadLine());

double srM = 0, srW = 0, countM = 0, countW = 0, height = 0;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Это мальчик? (Y/N)");
    string answer = Console.ReadLine();

    if (answer == "Y")
    {
        Console.WriteLine("Напишите рост мальчика (в метрах)");
        height = double.Parse(Console.ReadLine());
        countM++;
        srM += height;
    }
    else if (answer == "N")
    {
        Console.WriteLine("Напишите рост девочки (в метрах)");
        height = double.Parse(Console.ReadLine());
        countW++;
        srW += height;
    }
    else
    {
        Console.WriteLine("Нужно написать Y или N (да или нет)");
        i = i - 1;
    }
}
Console.WriteLine($"Средний рост мальчиков {srM / countM} м");
Console.WriteLine($"Средний рост девочек {srW / countW} м");