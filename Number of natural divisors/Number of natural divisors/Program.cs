using System;

internal class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
