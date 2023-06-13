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
        Console.Clear();

        foreach(Shapes shape in shapes)
        {
            string color = shape.GetColor();
            Thread.Sleep(2000);
            double area = shape.CalculateArea();
            string geometry = shape.GetName();
            Console.WriteLine($"The {color} color has the shape of a {geometry} and has an area of {area}");
        }


    }
}