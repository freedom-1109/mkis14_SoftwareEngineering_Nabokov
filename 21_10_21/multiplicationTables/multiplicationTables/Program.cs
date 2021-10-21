using System;

namespace multiplicationTables
{
    internal class Program
    {
        /*
         * Используя вложенные циклы, вывести таблицы умножения от второй до шестой
         */
        public static void Main(string[] args)
        {
            Console.WriteLine();
            TbV1();
            Console.WriteLine();
            TbV2();
        }

        private static void TbV1()
        {
            for (var i = 1; i < 10; i++)
            {
                for (var j = 2; j < 6 + 1; j++)
                {
                    Console.Write($"{j} * {i} = {j * i}\t");
                }
                Console.WriteLine();
            }
        }

        private static void TbV2()
        {
            Console.WriteLine("\t2\t3\t4\t5\t6");
            for (var i = 2; i < 6 + 1; i++)
            {
                Console.Write(i);
                for (var j = 2; j < 6 + 1; j++)
                {
                    Console.Write($"\t{i*j}");
                }
                Console.WriteLine();
            }
        }
    }
}