using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            string lastBigKag = string.Empty;
            double lastVolumKag = 0;
            for (int i = 0; i < n; i++)
            {
                string modelKag = Console.ReadLine();
                double radiusKag = double.Parse(Console.ReadLine());
                uint heightKag = uint.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radiusKag, 2) * heightKag;

                if (lastVolumKag < volume)
                {
                    lastVolumKag = volume;
                    lastBigKag = modelKag;
                }



            }
            Console.WriteLine(lastBigKag);
        }
    }
}
