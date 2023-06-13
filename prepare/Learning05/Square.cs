using System;

public class Square : Shapes
{
    private float _side;

    public float GetSide()
    {
        return _side;
    }

    public Square(float s, string color, string name) :base(color, name)
    {
        _side = s;
    }

    public override double CalculateArea()
    {
        return (GetSide() * GetSide());
    }
}