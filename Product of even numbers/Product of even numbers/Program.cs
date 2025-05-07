using System;

namespace Product_of_even_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int mult = 1;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    mult *= i;
                }
            }
            Console.WriteLine(mult);
        }
    }
}
