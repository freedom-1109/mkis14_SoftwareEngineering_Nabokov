using System;

namespace Exercise1
{
    internal class Program
    {
        // задание 1
        private static void Main(string[] args)
        {
            var sides = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
            Perimetr(sides[0], sides[1], sides[2],out var res);
            Console.WriteLine(res);
        }

        private static void Perimetr(int a, int b, int c, out int res)
        {
            if (a < b + c && b < a + c && c < a + b)
                res = a + b + c;
            else
                res = -1;
        }
    }
}