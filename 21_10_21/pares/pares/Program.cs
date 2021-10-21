using System;

namespace pares
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int count = 0, sumcount = 0;
            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i < n + 1; i++)
            {
                for (var j = i - 1; j > 0; j--)
                {
                    if ((i + j) % 10 != 0) continue;
                    count += 2;
                    sumcount += 10;
                }
            }
            Console.WriteLine($"{count}, {sumcount}");
        }
    }
}