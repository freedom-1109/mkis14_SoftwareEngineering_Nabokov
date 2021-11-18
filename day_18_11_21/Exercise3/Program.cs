using System;
using System.Linq;

namespace Exercise3
{
    internal class Program
    {
        /*
         * Задан массив из n целых чисел.
         * Найти сумму и количество чисел, больших среднего арифметического элементов массива.
         */
        public static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), input => int.Parse(input));

            double average = (double) nums.Sum() / nums.Length;
            int count = nums.Count(x => x > average);
            int sum = 0;
            Array.ForEach(nums, x => sum += x > average?x:0);
            
            Console.WriteLine("\nНайти сумму и количество чисел, больших среднего арифметического элементов массива.\n" +
                              $"сумма = {sum}\n" +
                              $"количество = {count}");
        }
    }
}