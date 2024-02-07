using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        Circle circle = new Circle();
        Square square = new Square();


        square.SetColor("Blue");
        square.SetSide(10);
        square.SetName("Square");

        rectangle.SetColor("White");
        rectangle.SetWidth(10);
        rectangle.SetLength(12);
        rectangle.SetName("Rectangle");

        circle.SetColor("Red");
        circle.SetRadius(10);
        circle.SetName("Circle");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape sh in shapes) {

            string name = sh.GetName();
            double area = sh.GetArea();
            string color = sh.GetColor();

            Console.WriteLine($"{name} ({color}) Area: {area}");
        }


    }
}