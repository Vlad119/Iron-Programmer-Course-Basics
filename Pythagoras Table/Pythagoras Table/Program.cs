using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0) Console.WriteLine("Таблица пустая");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(j * i + " ");
            }
            Console.WriteLine();
        }
    }
}
