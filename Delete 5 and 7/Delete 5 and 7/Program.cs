using System;

internal class Program
{
    static void Main(string[] args)
    {
        int digit = int.Parse(Console.ReadLine());
        int result = 0;
        int multiplier = 1;
        while (digit > 0)
        {
            int currentDigit = digit % 10;
            if (currentDigit != 5 && currentDigit != 7)
            {
                result += currentDigit * multiplier;
                multiplier *= 10;
            }
            digit /= 10;
        }
        Console.WriteLine(result);
    }
}
