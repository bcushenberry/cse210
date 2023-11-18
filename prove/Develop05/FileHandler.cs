public class FileHandler
{
// --- Methods ---
    public void OutputToFile(List<Goal> userGoals, UserLevel userLevel)
    {
        Console.Write("What is the file name? ");      
        string fileName = Console.ReadLine();

        // Output the user's score and level first, then the goal list
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(userLevel.GetScore());
            outputFile.WriteLine(userLevel.GetLevel());            
            foreach (Goal goal in userGoals)
            {
                outputFile.WriteLine(goal.WriteToFile());
            }
        }
    }

    public void LoadFromFile(List<Goal> userGoals, UserLevel userLevel)
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        userGoals.Clear();

        string[] loadedGoals = File.ReadAllLines(fileName);

        // Use the first two lines to set the user's score and level
        userLevel.SetScore(int.Parse(loadedGoals[0]));
        userLevel.SetLevel(int.Parse(loadedGoals[1]));

        // Redefine the scope to skip the first two lines, then loop through the file to populate the goal list
        loadedGoals = loadedGoals.Skip(2).ToArray();
        foreach (string goal in loadedGoals)
        {
            string[] lines = goal.Split("\t");
            Goal newGoal;

            switch(lines[0])
            {
                case "Simple Goal":
                    newGoal = new SimpleGoal(lines[0], lines[1], lines[2], int.Parse(lines[3]), bool.Parse(lines[4]));
                    userGoals.Add(newGoal);
                    break;

                case "Eternal Goal":
                    newGoal = new EternalGoal(lines[0], lines[1], lines[2], int.Parse(lines[3]), int.Parse(lines[4]));
                    userGoals.Add(newGoal);
                    break;

                case "Checklist Goal":
                    newGoal = new ChecklistGoal(lines[0], lines[1], lines[2], int.Parse(lines[3]), int.Parse(lines[4]), int.Parse(lines[5]), int.Parse(lines[6]));
                    userGoals.Add(newGoal);
                    break;
            }
        }
    }
}