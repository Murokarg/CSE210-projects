using System;

public class Fraction
{
    // Private fields (data members)
    private int _top;
    private int _bottom;

    // Constructor 1: Default constructor
    public Fraction()
    {
        _top = 0;
        _bottom = 1; // Default fraction is 0/1 = 0
    }

    // Constructor 3: Whole number
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1; // Def
    }

    // Constructor 3: Whole number (e.g. 5 becomes 5/1)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for top
    public int GetTop()
    {
        return _top;
    }

    // Setter for top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction as a string like "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction (e.g., 3/4 -> 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom; // Cast to double to avoid integer division
    }


}