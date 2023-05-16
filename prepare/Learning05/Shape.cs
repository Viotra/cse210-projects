public class Shape
{
    private string _color;

    public Shape(string color)
    {
        SetColor(color);
    }

    public string GetColor()
    {
        return _color;
    }

    private void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        double area = 2 * 2;
        return area;
    }
}