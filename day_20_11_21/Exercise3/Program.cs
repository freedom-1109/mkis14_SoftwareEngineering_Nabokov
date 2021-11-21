using System;
using System.Diagnostics;

namespace Exercise3
{
    internal class Program
    {
        /*
         * Задание: Написать программу,
         * которая осуществляет капитализацию введенного пользователем текста.
         * В качестве разделителя слов использовать пробел.
         */
        public static void Main(string[] args)
        {
            Console.WriteLine(Capitalize(Console.ReadLine()));
        }

        private static string Capitalize(string str)
        {
            str = str[0].ToString().ToUpper() + str.Substring(1, str.Length-1);
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == ' ')
                    str = str.Substring(0, i) + str[i].ToString().ToUpper() + str.Substring(i + 1, str.Length - i - 1);
            }

            return str;
        }
    }
}