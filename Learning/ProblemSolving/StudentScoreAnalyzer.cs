namespace ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;

public class StudentScoreAnalyzer
{
    public int[] Scores { get; set; }

    public StudentScoreAnalyzer(int[] scores)
    {
        Scores = scores;
    }

    public double AverageScore()
    {
        int sum = 0;

        for (int i = 0; i < Scores.Length; i++)
        {
            sum += Scores[i];
        }

        return (double)sum / Scores.Length;
    }

    public int HighestScore()
    {
        int highest = Scores[0];

        for (int i = 1; i < Scores.Length; i++)
        {
            if (Scores[i] > highest)
            {
                highest = Scores[i];
            }
        }

        return highest;
    }

    public int LowestScore()
    {
        int lowest = Scores[0];

        for (int i = 1; i < Scores.Length; i++)
        {
            if (Scores[i] < lowest)
            {
                lowest = Scores[i];
            }
        }

        return lowest;
    }

    public List<int> ScoresAboveAverage()
    {
        double average = AverageScore();

        List<int> result = new List<int>();

        for (int i = 0; i < Scores.Length; i++)
        {
            if (Scores[i] > average)
            {
                result.Add(Scores[i]);
            }
        }

        return result;
    }

    public void Display()
    {
        Console.WriteLine($"Average Score : {AverageScore()}");
        Console.WriteLine($"Highest Score : {HighestScore()}");
        Console.WriteLine($"Lowest Score  : {LowestScore()}");

        Console.WriteLine("Scores Above Average:");

        foreach (int score in ScoresAboveAverage())
        {
            Console.WriteLine(score);
        }
    }

    public static int[] InputScores(int n)
    {
        int[] scores = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Enter score of student {i + 1}: ");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out int score))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                if (score < 0)
                {
                    Console.WriteLine("Score cannot be negative.");
                    continue;
                }

                scores[i] = score;
                break;
            }
        }

        return scores;
    }
}