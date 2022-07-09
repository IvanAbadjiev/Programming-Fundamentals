using System;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine()); 
            var minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes >= 60)
            {
                minutes -= 60;
                hours++;
                if (hours > 23)
                {
                    hours = 0;
                }
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
