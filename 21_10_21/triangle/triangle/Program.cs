using System;

namespace triangle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var m = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i <= m; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}