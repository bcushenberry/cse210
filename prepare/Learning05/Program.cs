using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("purple", 4);
        Rectangle rectangle = new Rectangle("blue", 2, 6);
        Circle circle = new Circle("yellow", 3);
/*
        Console.WriteLine($"Color: {square.GetColor()}\tArea: {square.GetArea()}");
        Console.WriteLine($"Color: {rectangle.GetColor()}\tArea: {rectangle.GetArea()}");
        Console.WriteLine($"Color: {circle.GetColor()}\tArea: {circle.GetArea()}");
*/
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}\tArea: {shape.GetArea()}");
        }

    }
}