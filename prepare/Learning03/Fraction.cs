using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int bottom)
    {
        _bottom = bottom;
    }

    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }

    public int GetTop() {
        return _top;
    }

    public int GetBottom() {
        return _bottom;
    }

    public void SetTop(int top) {
        _top = top;
    }

    public void SetBottom(int bottom) {
        _bottom = bottom;
    }

    public void GetFractionString() {
        Console.WriteLine($"{GetTop()}/{GetBottom()}");
    }

    public double GetDecimalValue() {
        
        double top = GetTop();
        double bottom = GetBottom();
        double div = top / bottom;
        return div;
    }
    
}   
