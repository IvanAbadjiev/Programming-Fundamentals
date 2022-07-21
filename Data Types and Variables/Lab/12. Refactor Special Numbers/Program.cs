using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int total = 0;

            int thisNumber = 0;

            bool isSpecialNumber = false;

            for (int ch = 1; ch <= n; ch++)

            {

                thisNumber = ch;

                while (ch > 0)

                {

                    total += ch % 10;

                    ch = ch / 10;

                }

                isSpecialNumber = (total == 5) || (total == 7) || (total == 11);

                Console.WriteLine("{0} -> {1}", thisNumber, isSpecialNumber);

                total = 0;

                ch = thisNumber;

            }
        }
    }
}
