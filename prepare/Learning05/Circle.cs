using System;

public class Circle : Shapes
{
    private float _radius;

    public Circle(float radius, string color, string name) :base(color, name)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.Round(Math.PI * _radius * _radius, 2);
    }
}