using System;

public class Journal
{
    // Initializing the list of entries, the date/time used in the entries, and the random number used to give a random prompt
    private List<Entry> _entries = new List<Entry>();
    private DateTime _currentDate = DateTime.Now;
    private Random _random = new Random();

    // The list of prompts
    List<string> _prompts = new List<string>
    {
        "What was your favorite thing about today?",
        "What was one thing you didn't do today that you wish you would have?",
        "What is something that happened today that you're grateful for?",
        "What is something you learned today?",
        "Write a spiritual thought or impression you had today.",

    };

    // Silly little "encouragements" meant to make you feel good for writing something.
    List<string> _encouragements = new List<string>
    {
        "Interesting!",
        "Good answer!",
        "Another day, another journal entry done!",
        "You did it! You wrote in your journal today!",
        "Good on you for writing it down!"
    };

    public void NewEntry()
    {
        Entry userInput = new Entry();
        int i = _random.Next(_prompts.Count);
        int j = _random.Next(_encouragements.Count);

        userInput._entryNumber = _entries.Count +1;
        userInput._dateText = _currentDate.ToShortDateString();
        userInput._prompt = _prompts[i];

        Console.Write($"{userInput._prompt}\n> ");
        userInput._response = Console.ReadLine();
        
        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.WriteLine($"{_encouragements[j]}\n");
        Console.ForegroundColor = ConsoleColor.White;

        _entries.Add(userInput);
    }
    
    public void DisplayEntries()
    {
        Console.WriteLine("");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void OutputToFile()
    {
        Console.WriteLine("What is the file name?");      
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetOutput());
            }
        }
        Console.WriteLine("");        
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        _entries.Clear();

        string[] loadedEntries = File.ReadAllLines(fileName);

        foreach (string entry in loadedEntries)
        {
            string[] lines = entry.Split("\t");

            Entry newEntry = new Entry();
            newEntry._entryNumber = int.Parse(lines[0]);
            newEntry._dateText = lines[1];
            newEntry._prompt = lines[2];
            newEntry._response = lines[3];

            _entries.Add(newEntry);
        }
        Console.WriteLine("");
    }

}