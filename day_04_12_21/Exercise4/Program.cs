using System;
using System.Linq;

namespace Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            var M = Enumerable.Range(1, 100).Select(i => rnd.Next(-1000, 1000)).ToArray();

            Console.WriteLine(M.Count(i => 0 < i && i < 125));
        }
    }
}