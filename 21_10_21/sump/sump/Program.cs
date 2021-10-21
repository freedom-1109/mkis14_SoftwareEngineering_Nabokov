using System;

namespace sump
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                var x = 0;
                var N = Convert.ToInt32(Console.ReadLine());
                for (var i = 1; i <= N; i++)
                    x += i;
                Console.WriteLine(x);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ты чо, пес!");
            }
        }
    }
}