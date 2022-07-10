using System;

namespace _09.__Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var theAmountOfMoneyJoshHas = double.Parse(Console.ReadLine());
            var theCountOfStudents = int.Parse(Console.ReadLine());
            var thePriceOfLightsabers = double.Parse(Console.ReadLine());
            var thePriceOfRobes = double.Parse(Console.ReadLine());
            var thePriceOfBelts = double.Parse(Console.ReadLine());

            var studentThenMore = theCountOfStudents * 0.10;

            var freeBelt = theCountOfStudents / 6;

            var totallPriceL = thePriceOfLightsabers * (theCountOfStudents + Math.Ceiling(studentThenMore));
            var totalPriceR = thePriceOfRobes * theCountOfStudents;
            var totalPriceB = thePriceOfBelts * (theCountOfStudents - freeBelt);

            var finalPrice = totallPriceL + totalPriceB + totalPriceR;
            var diff = Math.Abs(theAmountOfMoneyJoshHas - finalPrice);

            if (finalPrice > theAmountOfMoneyJoshHas)
            {
                Console.WriteLine($"John will need {diff:f2}lv more."
);
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
            }



        }
    }
}
