using System;

namespace Sale_16._10
{
    internal class Program
    {
        /*
            Задание. Написать программу вычисления стоимости покупки с учетом скидки. 
            Скидка в 3% предоставляется в том случае, 
            если сумма покупки больше 500 руб., 
            в 5% - если сумма больше 1000 руб.
        */
        public static void Main(string[] args)
        {
            Console.Write("Введите стоимость покупки: ");
            /* стоимость покупок */
            var price = ReadDouble();
            
            /* расчет и вывод итоговой цены */
            if (price >= 500 && price < 1000)
                Console.WriteLine($"К оплате: {price * 0.97}");
            else if (price >= 1000)
                Console.WriteLine($"К оплате: {price * 0.95}");
            else
                Console.WriteLine($"К оплате: {price}");
        }
        
        /* заставляет ввести число */
        private static double ReadDouble()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Это не число, попробуйте еще раз.");
            }

            return result;
        }
    }
}