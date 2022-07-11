using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var curBalance = double.Parse(Console.ReadLine());

            var gameName = Console.ReadLine();
            var price = 0.00;
            bool flag = false;



            while (gameName != "Game Time")
            {

                if (curBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    flag = true;
                    break;
                }



                switch (gameName)
                {
                    case "OutFall 4":
                        if (curBalance >= 39.99)
                        {
                            price += 39.99;
                            curBalance -= 39.99;
                            Console.WriteLine($"Bought {gameName}"
);
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }



                        break;
                    case "CS: OG":
                        if (curBalance >= 15.99)
                        {
                            price += 15.99;
                            curBalance -= 15.99;
                            Console.WriteLine($"Bought {gameName}"
);
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "Zplinter Zell":
                        if (curBalance >= 19.99)
                        {
                            price += 19.99;
                            curBalance -= 19.99;
                            Console.WriteLine($"Bought {gameName}"
);
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "Honored 2":
                        if (curBalance >= 59.99)
                        {
                            price += 59.99;
                            curBalance -= 59.99;
                            Console.WriteLine($"Bought {gameName}"
);
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "RoverWatch":
                        if (curBalance >= 29.99)
                        {
                            price += 29.99;
                            curBalance -= 29.99;
                            Console.WriteLine($"Bought {gameName}"
);
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "RoverWatch Origins Edition":
                        if (curBalance >= 39.99)
                        {
                            price += 39.99;
                            curBalance -= 39.99;
                            Console.WriteLine($"Bought {gameName}"
);
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    default:
                        Console.WriteLine("Not Found");

                        break;
                }




                gameName = Console.ReadLine();



            }
            if (!flag)
            {
                Console.WriteLine($"Total spent: ${price:f2}. Remaining: ${curBalance:f2}");

            }


        }
    }
}
