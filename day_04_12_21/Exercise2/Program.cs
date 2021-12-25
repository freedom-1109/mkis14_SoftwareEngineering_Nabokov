using System;
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
            return Enumerable.Range(1, n).Count(i => n % i == 0);
        } 
    }
}