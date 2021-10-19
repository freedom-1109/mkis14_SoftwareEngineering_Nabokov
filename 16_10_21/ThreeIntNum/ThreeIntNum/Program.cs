using System;

namespace ThreeIntNum
{
    internal class Program
    {
        /*
            Даны три целых числа.
            Выбрать из них те,
            которые принадлежат интервалу [1,3].
            
            P.S. 
                не понял, должни принадлежать интервалу (1, 3), те 1 < x < 3
                                            или отрезку [1,3], те 1 <= x <= 3
                сделал принадлежащих отрезку, тк в задании [1,3], мат. языку я доверяю больше, чем русскому
        */
        public static void Main(string[] args)
        {
            const int numberOfNumbers = 3;
            const int lowerLimit = 1;
            const int upperLimit = 3;
            var numbers = new int[numberOfNumbers];
            
            // ввод чисел
            for (var i = 0; i < numberOfNumbers; i++)
                numbers[i] = ReadInt();
            
            // вывод чилел принадлежащих интервалу [lowerLimit, upperLimit]
            for (var i = 0; i < numberOfNumbers; i++)
                if (numbers[i] >= lowerLimit && numbers[i] <= upperLimit)
                    Console.Write($"{numbers[i]} ");
        }
        
        /* заставляет ввести целое число */
        private static int ReadInt()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Это не целое число, попробуйте еще раз.");
            }

            return result;
        }
    }
}