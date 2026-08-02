namespace ConsoleAppLearning1.Learning.Operator.Learning.SnakeLadderGame;

public class Board
{
    public Dictionary<int, int> SnakesAndLadders { get; } =
        new()
        {
            {4,14},
            {9,31},
            {20,38},
            {28,84},
            {40,59},
            {63,81},
            {71,91},

            {17,7},
            {54,34},
            {62,19},
            {64,60},
            {87,24},
            {93,73},
            {95,75},
            {99,78}
        };

    public int ApplySnakeOrLadder(int position)
    {
        return SnakesAndLadders.ContainsKey(position)
            ? SnakesAndLadders[position]
            : position;
    }
}