class Player
{
    public string Name { get; set; }
    public int Attempts { get; set; }
    public int BestScore { get; set; }

    public Player(string name)
    {
        Name = name;
        Attempts = 0;
        BestScore = int.MaxValue;
    }
}
