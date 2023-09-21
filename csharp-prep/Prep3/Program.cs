using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int magNum = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int magNum = randomGenerator.Next(1, 101);

        int guessNum = 0;

        Console.WriteLine("Try guessing the magic number! ");
        while (guessNum != magNum)
        {
            Console.Write("What is your guess? ");
            guessNum = int.Parse(Console.ReadLine());

            if (guessNum < magNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNum > magNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}