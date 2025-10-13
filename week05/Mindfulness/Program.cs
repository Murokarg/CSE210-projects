using System;


class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear(); // Cleans the screen
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("Select an activity (1-4): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            else if (choice == "4")
            {
                keepRunning = false; // Stops the loop 
                Console.WriteLine("Thank you for practicing mindfulness. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please press any key to try again.");
                Console.ReadKey(); // Waits for the user to press a key
            }
        }
    }
}