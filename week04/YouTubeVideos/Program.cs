using System;
using System.Collections.Generic;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        // Video 1
        Video video1 = new Video("OOP introduction in C#", "CodeNewbie", 650);
        video1.AddComment(new Comment("Richard", "Great explanation of OOP concepts!"));
        video1.AddComment(new Comment("Greg", "Awesome video, very helpful."));
        video1.AddComment(new Comment("Charlie", "Do you have a video about inheritance?"));

        // Video 2
        Video video2 = new Video("How to use List in C#", "DevTutor", 875);
        video2.AddComment(new Comment("Bob", "I really enjoyed this tutorial."));
        video2.AddComment(new Comment("Peter", "You made it so easy to understand."));
        video2.AddComment(new Comment("Juan", "Do you have a video about inheritance?"));

        // Video 3
        Video video3 = new Video("Introduction to encapsulation in C#", "MrDebugger", 952);
        video3.AddComment(new Comment("Gunther", "Great tutorial, keep up the good work."));
        video3.AddComment(new Comment("Joan", "This was very informative, thanks!"));
        video3.AddComment(new Comment("Valery", "I love your teaching style."));

        // Add videos to the List
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine(" ==== Comments ==== ");
            Console.WriteLine("\n");

            List<Comment> comments = video.GetComments();
            foreach (Comment comment in comments)
            {
                Console.WriteLine($" - {comment.CommenterName} {comment.text}");
            }
            Console.WriteLine("\n");
        }
    }


}