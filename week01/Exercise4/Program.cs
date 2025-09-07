using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int userNumber = -1;

        do
        {
            Console.Write("Enter a number or enter '0' to quit: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber > 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("The sum of the numbers is: " + sum);

        float average = (float)sum / numbers.Count;
        Console.WriteLine("The average of the numbers is: " + average);

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

        }
        Console.WriteLine("The maximun number is: " + max);
    }
}