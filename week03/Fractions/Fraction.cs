using System;

// Holds a fraction like 3/4. The top and bottom numbers are private, so other
// code must use the methods below instead of touching them directly.
public class Fraction
{
    private int _top;
    private int _bottom;

    // 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // e.g. 5 becomes 5/1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction as text, such as "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value, such as 0.75
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}