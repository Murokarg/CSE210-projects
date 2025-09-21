using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Example of use: You can change this for any biblical text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        // Show the full text at the beginning
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");

        // Main program loop
        while (!scripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine()?.Trim().ToLower();

            // Verify if the user wants to leave
            if (input == "quit")
            {
                Console.ReadKey();
                return; // Exits the Main method and finishes the program.
            }

            // If user press Enter (empty chain)
            if (input == "")
            {
                // Hides random words
                int wordsToHide = 3; // It can be modify
                scripture.HideRandomWords(wordsToHide);

                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }
            else
            {
                // If the user types other word than "quit"
                Console.WriteLine("Please, to exit the program enter 'quit'");
            }
        }

        // When all the words are hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram Finished!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        
    }

}