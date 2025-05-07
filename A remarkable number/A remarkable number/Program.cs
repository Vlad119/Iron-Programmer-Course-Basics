using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int originalNumber = n;
        int sumOfDigits = 0;
        while (n > 0)
        {
            sumOfDigits += n % 10;
            n /= 10;
        }
        if (sumOfDigits != 0 && originalNumber % sumOfDigits == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

