using System;
using System.Linq;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 300; i++)
            {
                Console.Write(Deliteli(i) == 5 ? $"{i} " : "");
            }
        }

        public static int Deliteli(int n)
        {
            return Enumerable.Range(1, n).Count(i => n % i == 0);
        }
    }
}