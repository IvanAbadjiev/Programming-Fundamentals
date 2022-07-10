using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();



            var price = 0.00;
            switch (type)
            {

                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        price = people * 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = people * 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = people * 10.46;
                    }

                    if (people >= 30)
                    {
                        price -= price * 0.15;
                    }
                    break;

                case "Business":
                    if (people >= 100)
                    {
                        people -= 10;
                    }


                    if (dayOfWeek == "Friday")
                    {
                        price = people * 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = people * 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = people * 16.00;
                    }
                    break;

                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        price = people * 15;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = people * 20;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = people * 22.50;
                    }
                    if (people >= 10 && people <= 20)
                    {
                        price -= price * 0.05;
                    }
                    break;


                default:
                    break;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
