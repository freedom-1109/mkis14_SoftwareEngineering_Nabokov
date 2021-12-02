using System;

namespace Exercise2
{
    internal class Program
    {
        // задание 1
        private static void Main(string[] args)
        {
            var sides = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
            Console.WriteLine(Perimetr(sides[0], sides[1], sides[2]));
        }

        private static int Perimetr(int a, int b, int c)
        {
            if (a < b + c && b < a + c && c < a + b)
                return a + b + c;
            return -1;
        }
    }
}