using System;

namespace Exercise2
{
    internal class Program
    {
        /* задание 2
         * 
         * Необходимо переделать предыдущую задачу,
         * теперь функция периметр должна возвращать целое значение.
         * Напомним задание: Вводятся три числа — длины трех сторон треугольника.
         * Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.
         */
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