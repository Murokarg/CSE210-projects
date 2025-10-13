using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment cs1 = new Assignment("Gordon James", "Division");
        Console.WriteLine(cs1.GetSummary());

        MathAssignment cs2 = new MathAssignment("Jonathan Reyes", "Calculus", "8.5", "5-20");
        Console.WriteLine(cs2.GetSummary());
        Console.WriteLine(cs2.GetHomeworkList());

        WritingAssignment cs3 = new WritingAssignment("Julia Roberts", "English Literature", "Studies in ProtoEnglish");
        Console.WriteLine(cs3.GetSummary());
        Console.WriteLine(cs3.GetWritingInformation());
    }
}