// Question: What suggestions would you give me to improve this code to better use the principle of abstraction?

// Answer:
/* To improve the code and make better use of the principle of abstraction, you can separate concerns and make the code more modular. Here are some suggestions:

1. Encapsulate the `Journal` class:
   - Consider creating a `Journal` class constructor to initialize its properties.
   - Move the `entries`, `currentDate`, `random`, `prompts`, and `encouragements` lists to private fields.
*/
public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private DateTime currentDate = DateTime.Now;
    private Random random = new Random();

    private List<string> prompts = new List<string> { /* ... */ };
    private List<string> encouragements = new List<string> { /* ... */ };

    public Journal()
    {
        // Constructor to initialize the journal properties.
    }

    // Other methods go here...
}

/*
2. Encapsulate Entry creation:
   - Consider creating a separate method for creating new `Entry` objects based on the provided prompts.

*/
private Entry CreateNewEntry()
{
    Entry userInput = new Entry();
    userInput._dateText = currentDate.ToShortDateString();
    userInput._entryNumber = entries.Count + 1;
    int i = random.Next(prompts.Count);
    userInput._prompt = prompts[i];
    Console.Write($"{prompts[i]}\n> ");
    userInput._response = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{encouragements[i]}\n");
    Console.ForegroundColor = ConsoleColor.White;
    return userInput;
}

/*
3. Use abstraction for I/O operations:
   - Consider creating a separate class or set of methods for handling file I/O operations to abstract them further. This helps make the `Journal` class more focused on journal-related functionality.

*/
public void OutputToFile(string fileName)
{
    // Code for writing entries to a file.
}

public void LoadFromFile(string fileName)
{
    // Code for loading entries from a file.
}

/*
4. Encapsulate display logic:
   - You can create a separate method to display entries in a more organized and cleaner way, instead of having the display logic within the `DisplayEntries` method.

*/

public void DisplayEntries()
{
    Console.WriteLine("");
    foreach (Entry entry in entries)
    {
        DisplayEntry(entry);
    }
}

private void DisplayEntry(Entry entry)
{
    Console.WriteLine($"Entry #{entry._entryNumber}\tDate: {entry._dateText}\nPrompt: {entry._prompt}\nResponse: {entry._response}\n");
}

/*
5. Validate user input:
   - Add input validation to ensure that the user enters valid choices and handle exceptions if the input is not an integer.

6. Consider using constants for menu options and make your code more readable by using switch statements for menu options.

By abstracting these components and encapsulating them within separate methods or classes, you can improve code organization and maintainability. This approach follows the Single Responsibility Principle and makes your code easier to understand and extend.
*/
