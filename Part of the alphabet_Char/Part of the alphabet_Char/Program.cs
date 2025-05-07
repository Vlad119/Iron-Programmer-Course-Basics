using System;

internal class Program
{
    static void Main(string[] args)
    {
        char c = char.Parse(Console.ReadLine());
        for (char ch = 'a'; ch <= c; ch++)
        {
            Console.Write(ch + " ");
        }
    }
}
