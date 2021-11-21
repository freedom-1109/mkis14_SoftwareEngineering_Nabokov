using System;

namespace Exercise1
{
    internal class Program
    {
        /*
         * Проверить является введенный пользователем палиндромом или нет.
         * Пробелы и регистр символов в строке игнорировать.
         */
        public static void Main(string[] args)
        {
            string s = Console.ReadLine()?.ToLower().Replace(" ", "");

            Console.WriteLine(IsPalindrome(s)?"YES":"NO");
        }
        private static bool IsPalindrome(string str)
        {
            bool f = true;
            for (int i = 0; i < str.Length/2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    f = false;
            return f;
        }
    }
}