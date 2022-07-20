using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
