using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var total = 0.00;
            for (int i = 1; i <= n; i++)
            {
                var perCapsulePrice = double.Parse(Console.ReadLine());
                var days = int.Parse(Console.ReadLine());
                var capsuleCount = int.Parse(Console.ReadLine());

                var sumPricePerOrder = ((days * capsuleCount) * perCapsulePrice);

                total += sumPricePerOrder;
                Console.WriteLine($"The price for the coffee is: ${sumPricePerOrder:f2}");

            }

            Console.WriteLine($"Total: ${total:f2}");

        }
    }
}
