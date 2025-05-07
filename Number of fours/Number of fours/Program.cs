using System;

namespace Number_of_fours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n > 0)
            {
                if (n % 10 == 4)
                {
                    count++;
                }
                n /= 10;
            }
            Console.WriteLine(count);
        }
    }
}
