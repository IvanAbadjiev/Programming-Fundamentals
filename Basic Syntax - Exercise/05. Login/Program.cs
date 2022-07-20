using System;

public static class Extensions
{
    public static string Reverse(this string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}

public class Example
{
    public static void Main()
    {
        string username = Console.ReadLine();

        string password = username.Reverse();



        bool isBlocked = false;
        var curentPass = Console.ReadLine();
        var counter = 0;
        while (curentPass != password)
        {
            counter++;
            if (counter == 4)
            {
                Console.WriteLine($"User {username} blocked!");
                isBlocked = true;
                break;
            }
            Console.WriteLine("Incorrect password. Try again.");
            curentPass = Console.ReadLine();



        }
        if (!isBlocked)
        {
            Console.WriteLine($"User {username} logged in.");
        }

    }
}