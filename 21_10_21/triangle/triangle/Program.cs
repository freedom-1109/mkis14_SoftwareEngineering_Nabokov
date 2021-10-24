using System;

namespace triangle
{
    internal class Program
    {
        /*
            Вывести на экран, консольного приложения, прямоугольный треугольник из звездочек “*”, с длиной катета m
         */
        public static void Main(string[] args)
        {
            var m = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i <= m; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
