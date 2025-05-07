using System;

internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                Console.Write(number % 10);
                number /= 10;
            }
        }
    }
