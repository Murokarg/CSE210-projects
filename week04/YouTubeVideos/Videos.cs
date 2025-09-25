using System;
using System.Collections.Generic;
using System.Dynamic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>(); // Initialize an empty list of comments

    }

    // Getter and setter for title
    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    }

    // Getter and setter for author
    public string Author
    {
        get
        {
            return _author;
        }
        set
        {
            _author = value;
        }
    }

    // Getter and setter for length in seconds
    public int LengthInSeconds
    {
        get
        {
            return _lengthInSeconds;
        }
        set
        {
            _lengthInSeconds = value;
        }
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display a copy of the list of comments
    // This prevents external modification of the original list
    public List<Comment> GetComments()
    {
        return new List<Comment>(_comments); // Return a copy of the comments list
    }


}

