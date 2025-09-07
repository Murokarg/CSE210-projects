using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        bool playAgain = true;
        int guess;
        int attempts;
        String response;

        while (playAgain == true)
        {
            guess = 0;
            attempts = 0;
            response = "";

            while (guess != number)
            {
                Console.Write("Pick a number between 1 and 100: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                attempts++;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine("It took you " + attempts + "attempts");

            Console.WriteLine("Do you want to play again? (Y/N): ");
            response = Console.ReadLine().ToUpper();

            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
        Console.WriteLine("Thanks for playing!");
    }
}