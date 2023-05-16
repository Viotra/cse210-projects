using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 4.5f);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("blue", 1.87, 22.45);

        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle cirle = new Circle("yellow", 2);

        Console.WriteLine(cirle.GetColor());
        Console.WriteLine(cirle.GetArea());

    }
}