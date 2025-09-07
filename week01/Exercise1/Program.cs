using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your fist name? ");
        String firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        String lastName = Console.ReadLine();

        System.Console.WriteLine("Your name is " + lastName + ", " +  firstName + " "+ lastName);
    }
}