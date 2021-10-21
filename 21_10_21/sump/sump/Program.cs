using System;

namespace sump
{
    internal class Program
    {
        /*
         * Найти сумму первых N членов арифметической прогрессии с использованием цикла for
         */
        public static void Main()
        {
            
            var x = 0;
            int N;
            while (!int.TryParse(Console.ReadLine(),out N))
            {
                Console.WriteLine("Не число, попробуйте еще раз");
            }
            for (var i = 1; i <= N; i++)
                x += i;
            Console.WriteLine(x);
        }
    }
}