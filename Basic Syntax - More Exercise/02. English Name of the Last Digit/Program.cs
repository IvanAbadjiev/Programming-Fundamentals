using System;

namespace _02._English_Name_of_the_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());


            var lastDigit = num % 10;
            var print = string.Empty;

            switch (lastDigit)
            {
                case 0:
                    print = "zero";
                    break;

                case 1:
                    print = "one";
                    break;
                case 2:
                    print = "two";
                    break;
                case 3:
                    print = "three";
                    break;
                case 4:
                    print = "four";
                    break;
                case 5:
                    print = "five";
                    break;
                case 6:
                    print = "six";
                    break;
                case 7:
                    print = "seven";
                    break;
                case 8:
                    print = "eight";
                    break;
                case 9:
                    print = "nine";
                    break;
                default:
                    break;
            }
            Console.WriteLine(pr);

        }
    }
}
