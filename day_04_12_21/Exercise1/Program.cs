using System;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 120; i < 140 + 1; i++)
            {
                Console.WriteLine($"{i}\tимеет\t{Deliteli(i)}\tделителей");
            }
        }

        public static int Deliteli(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }

            return count;
        }
    }
}