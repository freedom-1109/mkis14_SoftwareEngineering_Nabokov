using System;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 300; i++)
            {
                Console.Write(Deliteli(i) == 5 ? $"{i}\n" : "");
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