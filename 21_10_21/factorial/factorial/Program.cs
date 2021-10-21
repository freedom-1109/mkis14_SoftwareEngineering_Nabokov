using System;

namespace factorial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("не число, попробуй еще раз");
            }

            var ansver = (result < 0) ? result : fact(result);
            Console.WriteLine(ansver);
        }

        private static int fact(int N)
        {
            var x = 1;
            for (var i = 1; i <= N; i++)
            {
                x *= i;
            }

            return x;
        }
    }
}