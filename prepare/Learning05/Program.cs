using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes = new List<Shapes>();
        Square sq = new Square(3, "blue", "square");
        shapes.Add(sq);

        Rectangle rec = new Rectangle(4, 5, "green", "rectangle");
        shapes.Add(rec);
        shapes.Add(new Circle(3, "red", "circle"));
        shapes.Add(new Circle(1, "yellow", "circle"));
        shapes.Add(new Square(4, "white", "square"));
        shapes.Add(new Rectangle(12, 7, "violet", "rectangle"));
        Console.Clear();

        foreach(Shapes shape in shapes)
        {
            string color = shape.GetColor();
            Thread.Sleep(500);
            double area = shape.CalculateArea();
            string geometry = shape.GetName();
            Console.WriteLine($"The {color} color has the shape of a {geometry} and has an area of {area}");
        }
        Console.WriteLine();


    }
}