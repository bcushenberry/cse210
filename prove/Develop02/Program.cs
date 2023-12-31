using System;

// Exceeding Requirements
// Added the "Entry #" information so that each entry is counted.
// Added "encouragements" that give positive reinforcement each time an entry is completed. These are displayed in yellow in the console.
// Not sure if this counts, but I accounted for the use of punctuation by using tab separation (\t) rather than commas, semi-colons, etc.
// Thank you for reading (both this comment and the code)!

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        
        int choice = 0;
        
        Console.WriteLine("");
        Console.WriteLine("Greetings, Journalmaster! Ready to write?");
        do
        {
            Console.WriteLine("Here are your options: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Show all entries");
            Console.WriteLine("3. Save entries to a file");
            Console.WriteLine("4. Load entries from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            journal.NewEntry();
        }

        if (choice == 2)
        {
            journal.DisplayEntries();
        }

        if (choice == 3)
        {
            journal.OutputToFile();
        }

        if (choice == 4)
        {
            journal.LoadFromFile();
        }

        if (choice > 5)
        {
            Console.WriteLine("Please enter a number from 1 to 5.");
        }

        }

        while(choice != 5);
        
    }
}