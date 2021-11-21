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
            Console.WriteLine(IsPalindrome(Console.ReadLine())?"YES":"NO");
        }
        private static bool IsPalindrome(string str)
        {
            if (str == "") return false;
            
            str = str.ToLower().Replace(" ", "");
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        }
    }
}