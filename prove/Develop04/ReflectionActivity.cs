public class ReflectionActivity : Activity
{
// --- Attributes ---
    private List<string> _prompts;
    private List<string> _initialQuestions;
    private Random _random = new Random();

// --- Constructor ---    
    public ReflectionActivity(string name, string description, List<string> prompts, List<string> questions) : base (name, description)
    {
        _prompts = prompts;
        _initialQuestions = questions;
    }

// --- Methods ---
    public void Reflection()
    {
        StartActivity();
        AskDuration();        
        GetReady();

        ShowPrompt();

        EndActivity();
    }

    private void ShowPrompt()
    {
        int i = _random.Next(_prompts.Count());

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {_prompts[i]} ---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in... ");
        PauseTimer(5);

        Console.Clear();
        ShowQuestion();                
    }

    private void ShowQuestion()
    {
        // Implemented a simple method to ensure the second question doesn't match the first.
        // It takes some of the randomness out of the second question, but I think that's okay.
        int usedNumber = -1;

        for (int i = 0; i < 2; i++)
        {
            int j = _random.Next(_initialQuestions.Count());

            if (j == usedNumber && (j + 1) < _initialQuestions.Count())
                {
                    j++;
                }

            else if (j == usedNumber && (j + 1) >= _initialQuestions.Count())
                {
                    j--;
                }

            Console.Write($"> {_initialQuestions[j]} ");
            PauseAnimation(GetDuration()/2);
            Console.WriteLine("");
            usedNumber = j;
        }
        Console.WriteLine("");
    }
}