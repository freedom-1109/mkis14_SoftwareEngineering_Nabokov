using System;
using System.Linq;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 120; i < 140 + 1; i++)
            {
                Console.WriteLine($"{i} имеет {Deliteli(i)} делителей");
            }
        }

        private static int Deliteli(int n)
        {
            return Enumerable.Range(1, n).Count(i => n % i == 0);
        }
    }
}