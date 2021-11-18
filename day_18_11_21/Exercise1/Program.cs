using System;

namespace Exercise1
{
    internal class Program
    {
        /*
            Задана последовательность целых чисел.
            Подсчитать количество элементов, у которых четные соседи.
        */
        public static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), input => int.Parse(input));
            
            Console.WriteLine(NeighborsCount(nums));
        }

        private static int NeighborsCount(int[] array)
        {
            int count = 0;
            
            if (array[1] % 2 == 0) count++;
            if (array[array.Length - 2] % 2 == 0) count++;

            for (int i = 1; i < array.Length - 1; i++)
                if (array[i - 1] % 2 == 0 && array[i + 1] % 2 == 0) count++;
            
            return count;
        }
    }
}