using System;

/*
For the "Exceeding the requirements" part of the assignment, I did two things:

1. Had the program load a list of scriptures from the file and then display a random scripture. Initially, I actually wrote the program using just the Proverbs scripture in the sample as a string, but after I was done with everything, I went back and rewrote a bunch to make it work with a file instead. I didn't allow the user to specify a file name or anything because I just wanted to get the core functionality in there. (That's also why there's only two scriptures in the file - one with two verses, and one with one.)

2. Made it so the HideWords method would only hide words that hadn't been hidden. I tried it initially without that and it took a long time to fully hide a scripture since it kept selecting words that were hidden, so I came up with a workaround.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Random random = new Random();
        List<Scripture> scriptures = new List<Scripture>();
        Scripture scripture = new Scripture();

        string fileName = "scriptures.txt";
        scripture.GetScriptureList(scriptures, fileName);

        int i = random.Next(scriptures.Count());
        scriptures[i].DisplayScripture();

        Console.Write("Press enter to continue or type \"quit\" to finish:\n");

// I realize the following loop has issues.
// Please see note at bottom.
        bool keepLooping = true;
        do
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                scriptures[i].HideWords();
                scriptures[i].DisplayScripture();
                Console.Write("Press enter to continue or type \"quit\" to finish:\n");
                if (Console.ReadLine() == "quit" || scriptures[i].AllHidden() == true)
                {
                    keepLooping = false;
                }
            }
        }
        while (keepLooping);
    }
/*
The code here is probably the millionth variation of it that I've tried,
but it still doesn't match the sample video perfectly and I can't figure out how to fix it.

In the sample video, every time you press enter, three words disappear.
You can type "quit" and press enter at any time to quit.

However, in my program, it alternates between checking for enter (Console.ReadKey) and checking for quit (Console.ReadLine).
This means that the first time you press enter, it will hide three words - even if you type "quit" and press enter.
Then the cursor will go down one line, where you can type "quit" to end the program.
If you don't type "quit" but only press enter, the cursor will go back up a line, and then the cycle repeats.
In other words, to run the HideWords method, you have to press enter twice after the initial press,
and to quit, you have to first press enter once, and then type "quit" and enter.

I haven't figured out how to structure the code so that it doesn't do this.
Everything I've tried has failed in some way or produced the same results.
I'm sure the solution is simple, but for some reason I'm just not seeing.

Also, the reason I'm using a bool for the loop is that in the sample video,
once the scripture is completely hidden, you have to press enter again for the program to exit.

In my other attempts at this loop, the program would automatically close once the scripture was hidden,
so I changed it to using a bool so that the experience would match the sample video.
*/
}