using System;

internal class Program
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        int d1, d2, d3, d4;
        year++;
        while (true)
        {
            d4 = year % 10;
            d3 = year / 10 % 10;
            d2 = year / 100 % 10;
            d1 = year / 1000;
            if (d4 != d3 && d4 != d2 && d4 != d1 && d3 != d2 && d3 != d1 && d2 != d1)
            break;
            else year++;
        }
        Console.Write(year);
    }
}
