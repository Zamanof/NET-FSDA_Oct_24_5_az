// Liskov Substitution

Rectangle rectangle = new(width: 22, height: 30);
Console.WriteLine(Calculate.RectangleArea(rectangle));
rectangle.Width = 20;
Console.WriteLine(Calculate.RectangleArea(rectangle));
Console.WriteLine();

Square square = new(20);
Console.WriteLine(Calculate.RectangleArea(square));
square.Width = 10;
Console.WriteLine(Calculate.RectangleArea(square));

#region Bad example
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }
//}

//class Square : Rectangle
//{
//    public Square(double side) : base(side, side)
//    {}
//}

//class Calculate
//{
//    public static double RectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;
//}

#endregion

#region Good example
class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
}

class Square : Rectangle
{
    public override double Height 
    { 
        get => base.Height; 
        set {
            base.Height = value;
            base.Width = value;
        } 
    }

    public override double Width { 
        get => base.Width;
        set {
            base.Height = value;
            base.Width = value;
        } 
    }
    public Square(double side) : base(side, side)
    { }
}

class Calculate
{
    public static double RectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;
}

#endregion
