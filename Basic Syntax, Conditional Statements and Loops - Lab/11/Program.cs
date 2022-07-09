using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            
            for (int i = num2; i <= 100 ; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
                if (i >= 10 )
                {
                    break;
                }
            }
        }
    }
}
