using System;

namespace Exercise2
{
    internal class Program
    {
        /*
         * Задание: Написать программу для получения реверсированной строки.
         */
        
        public static void Main(string[] args)
        {
            Console.WriteLine(Reverse(Console.ReadLine()));
        }
        private static string Reverse(string str)
        {
            string r = null;
            for (int i = str.Length - 1; i >= 0; i--)
                r += str[i];
            return r;
        }
    }
}