int n = 0;

// Keep asking until the user enters a number greater than 1
while (n <= 1)
{
    Console.Write("Enter a number greater than 1: ");
    n = int.Parse(Console.ReadLine());

    if (n <= 1)
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
}

for (int i = 2; i <= n; i++)
{
    bool isPrime = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(i);
    }
}
