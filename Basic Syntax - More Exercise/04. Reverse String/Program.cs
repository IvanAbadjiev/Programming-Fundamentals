using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();




            for (int i = input.Length - 1; i >= 0; i--)
            {
                char curentSymbol = input[i];


                Console.Write(curentSymbol);

            }




        }
    }
}
