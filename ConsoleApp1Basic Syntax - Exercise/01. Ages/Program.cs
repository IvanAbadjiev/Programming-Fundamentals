using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());

            var type = string.Empty;


            if (age >= 0 && age <= 2)
            {
                type = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                type = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                type = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                type = "adult";
            }
            else if (age >= 66)
            {
                type = "elder";
            }
            else
            {

            }
            Console.WriteLine(type);
        }
    }
}
