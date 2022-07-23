using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            ushort capacity = 255;
            ushort sumLiter = 0;
            for (int i = 0; i < n; i++)
            {
                ushort curentLiteerAdd = ushort.Parse(Console.ReadLine());

                if (curentLiteerAdd <= capacity)
                {
                    sumLiter += curentLiteerAdd;
                    capacity -= curentLiteerAdd;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }



            }
            Console.WriteLine(sumLiter);

        }
    }
}
