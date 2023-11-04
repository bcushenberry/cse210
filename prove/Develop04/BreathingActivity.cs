public class BreathingActivity : Activity
{
// --- Constructor ---
    public BreathingActivity(string name, string description) : base (name, description)
    {
    }

// --- Methods ---

/* The breathing activity in the video doesn't stick to the time entered by the user.
    He enters 30 seconds for the duration, but the whole thing takes 50 seconds:

    "Get ready" -> 5 seconds of waiting -> 35 seconds of breathing -> "Well done" -> 
    5 seconds of waiting -> End message -> 5 seconds of waiting 

    I reproduced that at first, but decided to make sure the breathing itself adheres to
    the user's input. */

    public void Breathe()
    {
        int cycles;

        StartActivity();
        AskDuration();
        cycles = SetCycles();
        GetReady();

        for (int i = 0; i < cycles; i++)
        {
            BreathingCycle(cycles);
        }

        EndActivity();
    }

    private void BreathingCycle(int cycles = 3)
    {
        Console.Write("Breathe in... ");
        PauseTimer(GetDuration()/(cycles*2));
        Console.WriteLine("");
        Console.Write("Now breathe out... ");
        PauseTimer(GetDuration()/(cycles*2));
        Console.WriteLine("\n");        
    }

    private int SetCycles()
    {
        Console.Write("How many breathing cycles would you like to do within that time? ");
        int cycles = int.Parse(Console.ReadLine());
        return cycles;        
    }
}