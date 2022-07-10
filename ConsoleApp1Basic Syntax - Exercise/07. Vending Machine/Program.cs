using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();


            var validCoin = 0.0;
            while (input != "Start")
            {
                var curentCoin = double.Parse(input);

                switch (curentCoin)
                {
                    case 0.1:
                        validCoin += curentCoin;
                        break;
                    case 0.2:
                        validCoin += curentCoin;
                        break;
                    case 0.5:
                        validCoin += curentCoin;
                        break;
                    case 1:
                        validCoin += curentCoin;
                        break;
                    case 2:
                        validCoin += curentCoin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {curentCoin}");
                        break;
                }
                input = Console.ReadLine();

            }
            var produkt = Console.ReadLine();

            while (produkt != "End")
            {
                switch (produkt)
                {
                    case "Nuts":
                        if (validCoin >= 2.0)
                        {
                            validCoin -= 2.00;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Water":
                        if (validCoin >= 0.7)
                        {
                            validCoin -= 0.7;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Crisps":
                        if (validCoin >= 1.5)
                        {
                            validCoin -= 1.5;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Soda":
                        if (validCoin >= 0.8)
                        {
                            validCoin -= 0.8;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Coke":
                        if (validCoin >= 1.0)
                        {
                            validCoin -= 1.00;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;


                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                produkt = Console.ReadLine();

            }
            Console.WriteLine($"Change: {validCoin:f2}");


        }
    }
}
