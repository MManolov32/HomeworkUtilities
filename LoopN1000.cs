using System;

class Program
{
    static void Main()
    {
        int start;

        while (true)
        {
            Console.Write("Enter a starting number (between -1000 and 999): ");

            try
            {
                start = int.Parse(Console.ReadLine());

                if (start < -1000 || start > 999)
                {
                    Console.WriteLine("Number must be between -1000 and 999. Try again.\n");
                    continue;
                }

                break; // Valid input → exit loop
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.\n");
            }
        }

        for (int i = start; i <= 999; i++)
        {
            if (i < 0)
                continue;

            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}
