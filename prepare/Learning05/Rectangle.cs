using System.Data;

public class Rectangle : Shape
{
    private double _lenght = 0;
    private double _width = 0;

    /* Getters */
    public double GetLenght() {
        
        return _lenght;
    }

    public double GetWidth() {

        return _width;
    }

    /* Setters */
    public void SetLength(double lenght) {

        _lenght = lenght;
    }

    public void SetWidth(double width) {

        _width = width;
    }

    /* Methods */
    public override double GetArea()
    {
        return _lenght * _width;
    }
}