using System;

/* For the "exceeding requirements" part of the assignment,
I made another activity that specifically asks the user to record
something they're thankful for today. There were some other small
changes made as well.
*/

class Program
{
    static void Main(string[] args)
    {
        
        
        BreathingActivity activity1;
        ReflectionActivity activity2;
        ListingActivity activity3;
        GratitudeActivity activity4;


        string activityName;
        string activityDescription;
        int choice = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Good day! Please select an activity.");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start gratitude activity");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                activityName = "Breathing Activity";
                activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

                activity1 = new BreathingActivity(activityName, activityDescription);
                activity1.Breathe();
            }

            if (choice == 2)
            {
                activityName = "Reflection Activity";
                activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                List<string> prompts = new List<string>();
                prompts.AddRange(new List<string>
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                });
                
                List<string> questions = new List<string>();
                questions.AddRange(new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                });

                activity2 = new ReflectionActivity(activityName, activityDescription, prompts, questions);
                activity2.Reflection();
            }

            if (choice == 3)
            {
                activityName = "Listing Activity";
                activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                List<string> prompts = new List<string>();
                prompts.AddRange(new List<string>
                {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                });

                activity3 = new ListingActivity(activityName, activityDescription, prompts);
                activity3.Listing();
            }

            if (choice == 4)
            {
                activityName = "Gratitude Activity";
                activityDescription = "This activity will help you identify at least one thing to be grateful for every day. There is no time limit, but you will be shown how long you spent on the activity at the end.";

                activity4 = new GratitudeActivity(activityName, activityDescription);
                activity4.Gratitude();
            }

            if (choice > 5)
            {
                Console.WriteLine("Please enter a number from 1 to 4.");
            }
        }
        while (choice != 5);
    }
}