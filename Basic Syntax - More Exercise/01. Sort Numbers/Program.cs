
using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());



            int[] list = { num1, num2, num3 };


            Array.Sort(list);
            Array.Reverse(list);


            foreach (var i in list)
            {
                Console.WriteLine(i);

            }
        }
    }
}
