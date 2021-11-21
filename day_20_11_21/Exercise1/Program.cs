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
            bool f = true;
            string s = Console.ReadLine()?.ToLower().Replace(" ", "");
            for (int i = 0; i < s.Length/2; i++)
                if (s[i] != s[s.Length - 1 - i])
                    f = false;
            
            Console.WriteLine(f?"YES":"NO");
        }
    }
}