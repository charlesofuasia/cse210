using  System;

public class Shapes
{
    protected string _color;
    protected string _name;   

    public Shapes(string color, string name)
    {
        _color = color;
        _name = name;
    }

    public string GetColor()
    {
        return _color;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual double CalculateArea()
    {
        return -1;

    }
}