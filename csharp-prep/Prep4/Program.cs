using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userInput = -1;
        int total = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers and type 0 when finished.");

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        }
        
        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];

            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        float average = ((float)total) / numbers.Count;
        Console.WriteLine("The sum is: " + total);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: "+ largest);
    }
}