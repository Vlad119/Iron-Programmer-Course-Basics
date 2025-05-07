using System;

internal class Program
{
    static void Main(string[] args)
    {
        int firstN = int.Parse(Console.ReadLine());
        int secondN = int.Parse(Console.ReadLine());
        int count = 0;
        while (secondN != 0)
        {
            if (firstN < secondN) count++;
            firstN = secondN;
            secondN = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(count);
    }
}

