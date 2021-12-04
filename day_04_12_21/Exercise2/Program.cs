using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}{new string('+', Deliteli(i))}");
            }
        }

        private static int Deliteli(int n)
        {
            return Inumbs(1, n + 1).Count(i => n % i == 0);
        }

        private static IEnumerable<int> Inumbs(int start, int stop)
        {
            for (int i = start; i < stop; i++)
            {
                yield return i;
            }
        } 
    }
}