using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        string greeting = MagicGreeting(name);
        Console.WriteLine(greeting);
    }

    static string MagicGreeting(string name)
    {
        string[] messages =
        {
            $"Welcome, mighty {name}!",
            $"Greetings, traveler {name}!",
            $"Behold, the legendary {name} has arrived!",
            $"Ah, it's you again {name}!",
            $"{name}, prepare for greatness!"
        };

        Random rnd = new Random();
        int pick = rnd.Next(messages.Length);

        return messages[pick];
    }
}
