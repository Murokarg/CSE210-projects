using System;
using System.Collections.Generic;
using System.Dynamic;

public class Comment
{
    private string _commenterName;
    private string _text;

    // Constructor
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    // Getter and setter for commenter name
    public string CommenterName
    {
        get
        {
            return _commenterName;
        }
        set
        {
            _commenterName = value;
        }
    }

    // Getter and setter for comment text
    public string text
    {
        get
        {
            return _text;
        }
        set
        {
            _text = value;
        }
    }
}