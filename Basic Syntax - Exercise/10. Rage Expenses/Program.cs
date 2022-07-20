using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)

        {
            var loseGame = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keybordPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());

            var counterGameforHeadset = 0;
            var counterGameforMouse = 0;
            var counterGameforKeybord = 0;

            var trasedHeadset = 0;
            var trasedMouse = 0;
            var trasedKeybord = 0;
            var trasedDisplay = 0;

            bool mouseY = false;
            bool headsetY = false;
            for (int i = 1; i <= loseGame; i++)
            {
                counterGameforHeadset++;
                counterGameforMouse++;


                if (counterGameforHeadset == 2)
                {
                    trasedHeadset++;
                    counterGameforHeadset = 0;
                    headsetY = true;
                }
                if (counterGameforMouse == 3)
                {
                    trasedMouse++;
                    counterGameforMouse = 0;
                    mouseY = true;
                }

                if (mouseY && headsetY)
                {
                    counterGameforKeybord++;
                    trasedKeybord++;
                    if (counterGameforKeybord == 2)
                    {
                        trasedDisplay++;
                        counterGameforKeybord = 0;
                    }
                    headsetY = false;
                    mouseY = false;
                }
                else
                {
                    headsetY = false;
                    mouseY = false;
                }
            }

            var sum = (trasedMouse * mousePrice) + (trasedHeadset * headsetPrice) + (trasedKeybord * keybordPrice) + (trasedDisplay * displayPrice);

            Console.WriteLine($"Rage expenses: {sum:f2} lv."
);
        }
    }
}
