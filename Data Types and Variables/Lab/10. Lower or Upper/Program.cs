using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            int num = (int)(symbol);


            if (num >= 97 && num <= 122)
            {
                Console.WriteLine("lower-case");
            }
            else if (num >= 65 && num <= 90)
            {
                Console.WriteLine("upper-case");
            }


        }
    }
}
