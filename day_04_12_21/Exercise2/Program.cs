using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n} {new string('+', Deliteli(n))}");
            
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