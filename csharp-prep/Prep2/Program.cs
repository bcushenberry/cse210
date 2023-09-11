using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string response = Console.ReadLine();
        int grade = int.Parse(response);
        string letterGrade;
        
        // Calculate user's letter grade
        if (grade > 90)
        {
            letterGrade = "A";
        }
        else if (grade > 80)
        {
            letterGrade = "B";
        }
        else if (grade > 70)
        {
            letterGrade = "C";
        }
        else if (grade > 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Calculate + or - for the letter grade
        string plusMinus;

        if (grade < 93 && grade > 59 && ((grade / 10) > 6 || grade == 67 || grade == 68 || grade == 69))
        {
            plusMinus = "+";
        }
        else if (grade < 93 && grade > 59 && (grade / 10) < 3)
        {
            plusMinus = "-";
        }
        else
        {
            plusMinus = "";
        }

        // Show user their grade
        Console.WriteLine($"Your letter grade is: {letterGrade}{plusMinus}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass...");
        }
    }
}