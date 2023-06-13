using System;

public class Rectangle : Shapes
{
    private float _length;
    private float _width;

    public Rectangle(float l, float w, string color, string name) :base(color, name)
    {
        _length = l;
        _width = w;
    }

    public override double CalculateArea()
    {
        return _length * _width;
    }
}