class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Guess Game!");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Player player = new Player(name);

        Game game = new Game(player);
        game.Start();
    }
}
