using System;

namespace _06._Strong_number
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var startNumber = number;
            var Sumfact = 0;

            while (number != 0)
            {
                int digit = number % 10;

                int fact = 1;

                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }
                Sumfact += fact;

                number /= 10;

            }
            if (Sumfact == startNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {

                Console.WriteLine("no");
            }
        }
    }
}
