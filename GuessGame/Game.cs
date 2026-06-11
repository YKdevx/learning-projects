using System;

class Game
{
    private int secretNumber;
    private Player player;

    public Game(Player player)
    {
        this.player = player;
        Random random = new Random();
        secretNumber = random.Next(1, 101);
    }

    public void Start()
    {
        Console.WriteLine($"\nHello {player.Name}! Guess a number between 1 and 100.");

        while (true)
        {
            Console.Write("Your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            player.Attempts++;

            if (guess < secretNumber)
            {
                Console.WriteLine("📈 Bigger!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("📉 Smaller!");
            }
            else
            {
                Console.WriteLine($"🎉 Correct! You won in {player.Attempts} attempts.");

                if (player.Attempts < player.BestScore)
                {
                    player.BestScore = player.Attempts;
                    Console.WriteLine("🏆 New best score!");
                }

                break;
            }
        }
    }
}
