using System;
/* 
To exceed the requirements of this assignment, I implemented a level system where the user
can gain levels for every 1000 points earned. The user gets a reward for each level reached,
and a "big" reward for every five levels reached.
*/
class Program
{
    static void Main(string[] args)
    {
        List<Goal> userGoals = new List<Goal>();
        FileHandler fileHandler = new FileHandler();
        UserLevel userLevel = new UserLevel();
        int choice = 0;

        Console.WriteLine("Welcome to Eternal Quest!");
        do
        {
            Console.WriteLine($"\nCurrent score: {userLevel.GetScore()} points");
            Console.WriteLine($"Current level: {userLevel.GetLevel()}\n");
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == 1)
                {
                    userGoals.Add(new SimpleGoal("Simple Goal", name, description, points));
                }

                else if (goalType == 2)
                {
                    userGoals.Add(new EternalGoal("Eternal Goal", name, description, points));
                }

                else if (goalType == 3)
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int targetReps = int.Parse(Console.ReadLine());            

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    userGoals.Add(new ChecklistGoal("Checklist Goal", name, description, points, bonus, targetReps));
                }

                else 
                {
                    Console.WriteLine("Please enter a number from 1 to 3.");
                }
            }
                
            if (choice == 2)
            {
                Console.WriteLine("The goals are:");

                int i = 0;
                foreach (Goal goal in userGoals)
                {
                    Console.Write($"{i+1}. ");
                    goal.Display();
                    i++;
                }
            }

            if (choice == 3)
            {
                fileHandler.OutputToFile(userGoals, userLevel);
            }

            if (choice == 4)
            {
                fileHandler.LoadFromFile(userGoals, userLevel);
            }

            if (choice == 5)
            {
                Console.WriteLine("The goals are:");

                int i = 0;
                foreach (Goal goal in userGoals)
                {
                    Console.WriteLine($"{i+1}. {goal.GetName()}");
                    i++;
                }

                Console.Write("Which goal did you accomplish? ");
                int j = int.Parse(Console.ReadLine());

                int pointsEarned = userGoals[j-1].Record();
                Console.WriteLine();
                Console.WriteLine($"Great job! You earned {pointsEarned} points!");

                userLevel.CalculateTotalScore(pointsEarned);
            }

            if (choice > 6)
            {
                Console.WriteLine("Please enter a number from 1 to 6.");
            }
        }
        while (choice != 6);
    }
}