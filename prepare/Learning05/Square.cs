public class Square : Shape
{
    private double _side ;

    /* Getters */
    public double GetSide() {
        return _side;
    }

    /* Setters */
    public void SetSide(double side) {

        _side = side;
    }

    /* Methods */
    public override double GetArea()
    {
        return Math.Pow(_side, 2);
    }

}