using System;

internal class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= N; i++)
        {
            int number = i;
            while (number > 0)
            {
                if (number % 10 == 7) count++;
                number /= 10;
            }
        }
        Console.WriteLine(count);
    }
}
