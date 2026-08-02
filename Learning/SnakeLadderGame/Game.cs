namespace ConsoleAppLearning1.Learning.Operator.Learning.SnakeLadderGame;

public class Game
{
    private readonly Random random = new();
    private readonly Board board = new();

    public List<Player> Players { get; } = new();

    public int RollDice()
    {
        return random.Next(1, 7);
    }

    public void MovePlayer(Player player)
    {
        int dice = RollDice();

        Console.WriteLine($"\n{player.Name}'s Turn");
        Console.WriteLine($"Dice : {dice}");

        int oldPosition = player.Position;
        int newPosition = oldPosition + dice;

        if (newPosition > 100)
        {
            Console.WriteLine("Move skipped (Need exact 100)");
            return;
        }

        player.Position = newPosition;

        int finalPosition = board.ApplySnakeOrLadder(player.Position);

        if (finalPosition > player.Position)
        {
            Console.WriteLine("Ladder!");
        }
        else if (finalPosition < player.Position)
        {
            Console.WriteLine("Snake!");
        }

        player.Position = finalPosition;

        Console.WriteLine($"{oldPosition} -> {player.Position}");
    }

    public bool CheckWin(Player player)
    {
        return player.Position == 100;
    }

    public void Start()
    {
        bool winnerFound = false;

        while (!winnerFound)
        {
            foreach (Player player in Players)
            {
                MovePlayer(player);

                if (CheckWin(player))
                {
                    Console.WriteLine($"\n{player.Name} Wins!");
                    winnerFound = true;
                    break;
                }
            }
        }
    }
}