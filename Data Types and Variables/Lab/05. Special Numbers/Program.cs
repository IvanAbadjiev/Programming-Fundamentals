using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                int curentNumber = i;
                int sum = 0;
                while (curentNumber != 0)
                {
                    int lastDigit = curentNumber % 10;
                    sum += lastDigit;
                    curentNumber /= 10;

                }

                if (sum == 7 || sum == 5 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }




            }

        }
    }
}
