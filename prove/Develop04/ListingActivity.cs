public class ListingActivity : Activity
{
// --- Attributes ---
    private List<string> _prompts;
    private int _responseNum = 0;
    private Random _random = new Random();

// --- Constructor ---
    public ListingActivity(string name, string description, List<string> prompts) : base (name, description)
    {
        _prompts = prompts;
    }

// --- Methods ---
    public void Listing()
    {
        StartActivity();
        AskDuration();        
        GetReady();

        ShowPrompt();
        UserResponse();

        Console.WriteLine();
        Console.WriteLine($"You listed {_responseNum} items!\n");

        EndActivity();
    }

    private void ShowPrompt()
    {
        int i = _random.Next(_prompts.Count());

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[i]} ---\n");
        Console.Write("You may begin in... ");
        PauseTimer(5);
        Console.WriteLine();        
    }

    private void UserResponse()
    {      
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while(startTime < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _responseNum++;
            startTime = DateTime.Now;
        }
    }
}