using System;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int? min = null, max = null;
            MinmaxSeq(ref min, ref max);
            Console.WriteLine($"min: {min}\nmax:{max}");
        }

        private static void MinmaxSeq(ref int? min, ref int? max)
        {
            Console.WriteLine("Введите полседовательность и закончите ввод нулем:");
            min = max = int.Parse(Console.ReadLine());
            
            if (min == 0) return; // проверка на то, что пользователь первым числом ввел 0
            
            var x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}