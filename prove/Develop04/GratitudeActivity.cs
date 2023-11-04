public class GratitudeActivity : Activity
{
// --- Attributes ---
    private string _userInput;

// --- Constructor ---
    public GratitudeActivity(string name, string description) : base (name, description)
    {
    }

// --- Methods ---
    public void Gratitude()
    {
        StartActivity();
        Console.WriteLine("(Press enter to continue...)");
        Console.ReadLine();
        GetReady();

        GiveThanks();

        EndActivity();        
    }

    private void GiveThanks()
    {
        string saveToFile;
        DateTime startTime = DateTime.Now;

        Console.WriteLine("What is one thing that happened today that you are grateful for, and why?");
        Console.Write("> ");
        _userInput = Console.ReadLine();

        DateTime endTime = DateTime.Now;
        TimeSpan writingTime = endTime - startTime;
        SetDuration(writingTime.Seconds);

        Console.WriteLine("");
        Console.Write("Would you like to save today's entry? (y/n) ");
        saveToFile = Console.ReadLine();
        Console.WriteLine("");

        if (saveToFile == "y" || saveToFile == "yes" || saveToFile == "Y")
        {
            OutputToFile(_userInput);
            Console.WriteLine("\nSave complete!\n");
        }
       
        else
        {
            Console.WriteLine("Perhaps another time!\n");
        }
    }

    private void OutputToFile(string userInput)
    {
        Console.Write("Which file would you like to save to? ");
        string fileName = Console.ReadLine();
        DateTime currentDate = new DateTime();
        currentDate = DateTime.Today;

        using (StreamWriter outputFile = File.AppendText(fileName))
        {
            outputFile.WriteLine($"{currentDate.ToShortDateString()}:\t{userInput}");
        }
    }        
}