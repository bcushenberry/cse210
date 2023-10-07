using System;

public class Journal
{
    // Initializing the list of entries, the date/time used in the entries, and the random number used to give a random prompt
    List<Entry> entries = new List<Entry>();
    DateTime currentDate = DateTime.Now;
    Random random = new Random();

    // The list of prompts
    List<string> prompts = new List<string>
    {
        "What was your favorite thing about today?",
        "What was one thing you didn't do today that you wish you would have?",
        "What is something that happened today that you're grateful for?",
        "What is something you learned today?",
        "Write a spiritual thought or impression you had today.",

        // Adding some of the example prompts for more variety
        "Who was the most interesting person you interacted with today?",
        "How did you see the hand of the Lord in my life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?"

    };

    // Silly little "encouragements" meant to make you feel good for writing something.
    List<string> encouragements = new List<string>
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
        userInput._dateText = currentDate.ToShortDateString();

        userInput._entryNumber = entries.Count +1;

        int i = random.Next(prompts.Count);
        userInput._prompt = prompts[i];

        Console.Write($"{prompts[i]}\n> ");
        userInput._response = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.WriteLine($"{encouragements[i]}\n");
        Console.ForegroundColor = ConsoleColor.White;

        entries.Add(userInput);
    }
    
    public void DisplayEntries()
    {
        Console.WriteLine("");
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Entry #{entry._entryNumber}\tDate: {entry._dateText}\nPrompt: {entry._prompt}\nResponse: {entry._response}\n");
        }
    }

    public void OutputToFile()
    {
        Console.WriteLine("What is the file name?");      
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._entryNumber}\t{entry._dateText}\t{entry._prompt}\t{entry._response}");
            }
        }
        Console.WriteLine("");        
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        entries.Clear();

        string[] loadedEntries = File.ReadAllLines(fileName);

        foreach (string entry in loadedEntries)
        {
            string[] lines = entry.Split("\t");

            Entry newEntry = new Entry();
            newEntry._entryNumber = int.Parse(lines[0]);
            newEntry._dateText = lines[1];
            newEntry._prompt = lines[2];
            newEntry._response = lines[3];

            entries.Add(newEntry);
        }
        Console.WriteLine("");
    }

}