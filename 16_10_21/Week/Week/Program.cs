using System;

namespace Week
{
    internal class Program
    {
        // вывод дня недели по заданному числу
        public static void Main(string[] args)
        {
            var week = new[] {"Понедельник", "Вторник", "Среда", "Четверг", "пятница", "Суббота", "Воскресенье"};
            Console.Write("Введите номер дня недели: ");
            var day = ReadInt();
            
            /*
                было задание вывести ошибку, если нечисло выходит за пределы недели,
                решил, что возможность ввести число повторно будет лучше, тк пользователь должен получить ответ
            */
            while (day < 1 || day > 7)
            {
                Console.Write("Не является днем недели, попробуйте еще раз: ");
                day = ReadInt();
            }
            Console.WriteLine($"Вы ввели: \"{week[day - 1]}\"");
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