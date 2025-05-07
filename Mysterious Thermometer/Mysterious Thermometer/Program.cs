using System;

internal class Program
{
    static void Main(string[] args)
    {
        string s = string.Empty;
        double max = double.MinValue;
        double min = double.MaxValue;
        double summ = 0;
        int correct = 0;
        int incorrect = 0;
        while (s != "кажется, я сломался")
        {
            s = Console.ReadLine();
            if (double.TryParse(s, out double digit))
            {
                if (digit > max) max = digit;
                if (digit < min) min = digit;
                if (digit >= -50 && digit <= 100)
                {
                    summ += digit;
                    correct++;
                }
                else
                {
                    incorrect++;
                }
            }
        }
        if (summ != 0) Console.WriteLine($"Средняя температура: {summ / correct}");
        else Console.WriteLine($"Средняя температура: {summ}");
        Console.WriteLine($"Самая низкая температура: {min}");
        Console.WriteLine($"Самая высокая температура: {max}");
        if (correct >= incorrect) Console.WriteLine($"Совет: Термометр иногда врет, но жить можно. Держи его подальше от микроволновки!");
        else Console.WriteLine($"Совет: Артур, термометр явно с другой планеты! Выбрось его!");
    }
}
