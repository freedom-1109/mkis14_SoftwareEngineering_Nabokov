using System;
using System.Linq;

namespace Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            var M = new int[100];
            for (int i = 0; i < M.Length; i++)
                M[i] = rnd.Next(-1000, 1000);

            Console.WriteLine(M.Count(i => 0 < i && i < 125));
        }
    }
}