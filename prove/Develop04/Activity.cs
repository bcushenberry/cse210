public class Activity
{
// --- Attributes ---
    private string _startMsg;
    private string _endMsg;
    private string _activityName;
    private string _description;
    private int _duration;

// --- Constructor ---
    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
        _startMsg = $"Welcome to the {_activityName}.\n\n{_description}";
    }

// --- Methods ---
    protected void PauseTimer(int pauseTime)
    {
        for (int i = 0; i < pauseTime; i++)
        {
            Console.Write(pauseTime-i);
            Thread.Sleep(1000);
            Console.Write ("\b \b");
        }
    }

    protected void PauseAnimation(int pauseTime)
    {
        for (int i = 0; i < pauseTime; i++)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write ("\b \b");
            Console.Write ("\\");
            Thread.Sleep(250);
            Console.Write ("\b \b");
            Console.Write ("|");
            Thread.Sleep(250);
            Console.Write ("\b \b");
            Console.Write ("/");
            Thread.Sleep(250);
            Console.Write ("\b \b");            
        }
    }

// Originally I had the following three methods all in a single method called "StartActivity()"
// However, as I developed the project and changed things to exceed requirements, I found it 
// expedient to separate the single method into multiple methods.
    protected void StartActivity()
    {
        Console.WriteLine("");
        Console.WriteLine(_startMsg);
        Console.WriteLine("");
    }

    protected void AskDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...\n");
        PauseAnimation(5);        
    }

    protected void EndActivity()
    {
        _endMsg = $"You have completed another {GetDuration()} seconds of the {_activityName}.";

        Console.WriteLine("Well done!");
        PauseAnimation(5);
        Console.WriteLine("");

        Console.WriteLine(_endMsg);
        PauseAnimation(5);
        Console.Clear();        
    }

// --- Getters ---
    protected int GetDuration()
    {
        return _duration;
    }

// --- Setters ---
    protected void SetDuration(int duration)
    {
        _duration = duration;
    }
}