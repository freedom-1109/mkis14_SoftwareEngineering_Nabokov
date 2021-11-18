using System;
using System.Linq;

namespace Exercise2
{
    internal class Program
    {
        /*
         * Задан массив из n целых чисел.
         * Замените все наибольшие его элементы на наименьший,
         * а наименьшие элементы на наибольший.
         */
        public static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), input => int.Parse(input));

            int max = nums.Max();
            int min = nums.Min();
            
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == max) nums[i] = min;
                else if (nums[i] == min) nums[i] = max;

            foreach (var num in nums) 
                Console.Write($"{num} ");
        }
    }
}