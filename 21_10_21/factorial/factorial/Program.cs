using System;

namespace factorial
{
    internal class Program
    {
        /*
         * Вычислить факториал числа p(при p > 0), используя цикл do while.
         */
        public static void Main(string[] args)
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("не число, попробуй еще раз");
            }
            
            int i = 1, x = 1;
            do
            {
                x *= i++;
            } while (i <= result);
            Console.WriteLine(x);
        }
    }
}