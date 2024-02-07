public class Circle : Shape 
{
    private double _radius = 0;


    /* Getters */
    public double GetRadius() {

        return _radius;
    }

    /* Setters */
    public void SetRadius(double radius) {

        _radius = radius;
    }

    /* Methods */
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2) ;
    }
}