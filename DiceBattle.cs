using System;

class Program
{
    static Random rnd = new Random();

    static void Main()
    {
        int playerScore = 0;
        int enemyScore = 0;
        int evenCount = 0;

        for (int round = 1; round <= 5; round++)
        {
            int p = RollDice();
            int e = RollDice();

            if (p % 2 == 0) evenCount++;
            if (e % 2 == 0) evenCount++;

            Console.WriteLine($"Round {round}: Player rolled {p}, Enemy rolled {e}");
            playerScore += BattleRound(p, e);
            enemyScore += BattleRound(e, p);
        }

        AnnounceWinner(playerScore, enemyScore, evenCount);
    }

    static int RollDice()
    {
        return rnd.Next(1, 7);
    }

    static int BattleRound(int roll1, int roll2)
    {
        if (roll1 > roll2)
        {
            Console.WriteLine("Round winner!");
            return 1;
        }
        else if (roll1 == roll2)
        {
            Console.WriteLine("It's a tie!");
            return 0;
        }
        else
        {
            return 0;
        }
    }

    static void AnnounceWinner(int playerScore, int enemyScore, int evenCount)
    {
        Console.WriteLine();
        Console.WriteLine("Battle Over!");

        if (evenCount % 2 == 0)
        {
            Console.WriteLine("Even rolls everywhere → It's a tie!");
            return;
        }

        if (playerScore > enemyScore)
            Console.WriteLine("Player wins the whole game!");
        else if (playerScore == enemyScore)
            Console.WriteLine("Overall tie");
        else
            Console.WriteLine("Enemy wins the whole game!");
    }
}
