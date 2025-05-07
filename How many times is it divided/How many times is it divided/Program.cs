using System;

namespace How_many_times_is_it_divided
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int counter = 0;
            while (N % 3 == 0)
            {
                N /= 3;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
