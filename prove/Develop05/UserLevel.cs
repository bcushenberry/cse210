using System;

public class UserLevel
{
// --- Attributes ---
    private int _totalScore;
    private int _userLevel;
    private int _levelUpCounter;
    private Random _random = new Random();    

    private List<string> _smallRewards = new List<string>()
    {
        "Eat a dessert of your choice",
        "Watch a movie",
        "Read a fun book",
        "Play a game for an hour or two"
    };

    private List<string> _bigRewards = new List<string>()
    {
        "Buy something from your wishlist",
        "Buy tickets to a concert",
        "Go out to eat at a fancy restaurant",
        "Spend a day at the beach"
    };

// --- Constructor ---
    public UserLevel(int totalScore = 0, int userLevel = 1)
    {
        _totalScore = totalScore;
        _userLevel = userLevel;
    }

// --- Methods ---
    public void CalculateTotalScore(int pointsEarned)
    {
        _totalScore += pointsEarned;
        _levelUpCounter += pointsEarned;

        if (_levelUpCounter >= 1000)
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        // The purpose of the following variables is to allow for the user to gain multiple levels at once,
        // e.g. for when a large goal is accomplished that grants multiple levels.
        int previousLevel = _userLevel;
        int levelsGained = _userLevel + _levelUpCounter/1000 - previousLevel;

        _levelUpCounter -= 1000 * levelsGained;
        
        for (int i = 0; i < levelsGained; i++)
        {
            _userLevel++;
            Console.WriteLine();
            Console.WriteLine($"You gained a level! You are now at level {_userLevel}.");

            if (_userLevel % 5 == 0)
            {
                int j = _random.Next(_bigRewards.Count());
                Console.WriteLine("For reaching this level, you get a big reward!");
                Console.WriteLine($"Reward: {_bigRewards[j]}");
            }

            else
            {
                int k = _random.Next(_smallRewards.Count());
                Console.WriteLine("For reaching this level, you get a reward!");
                Console.WriteLine($"Reward: {_smallRewards[k]}");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Keep up the great work!");
    }

// --- Getters ---
    public int GetLevel()
    {
        return _userLevel;
    }

    public int GetScore()
    {
        return _totalScore;
    }

// --- Setters ---
    // These are needed when loading a file
    public void SetLevel(int userLevel)
    {
        _userLevel = userLevel;
    }

    public void SetScore(int totalScore)
    {
        _totalScore = totalScore;
    }
}