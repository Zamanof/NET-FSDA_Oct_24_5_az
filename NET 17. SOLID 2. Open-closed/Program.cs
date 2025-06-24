// Open/Closed principle

#region Bad example
//object[] shapes = [
//    new Rectangle(){Height = 34, Width = 30},
//    new Rectangle(){Height = 78.3, Width = 15.6},
//    new Circle(){Radius=36},
//    new Rectangle(){Height = 7, Width = 22},
//    new Triangle(){Height=25.6, Base=12}
//    ];

//Calculate calculate = new Calculate();
//Console.WriteLine(calculate.Areas(shapes));
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//}

//class Circle
//{
//    public double Radius { get; set; }
//}

//class Triangle
//{
//    public double Height { get; set; }
//    public double Base { get; set; }
//}

//class Calculate
//{
//    public double Areas(object[] shapes)
//    {
//        double areas = 0;
//        foreach (var shape in shapes)
//        {
//            if (shape is Rectangle rect) 
//                areas += rect.Width * rect.Height;
//            else if (shape is Circle circle) 
//                areas += Math.Pow(circle.Radius, 2) * Math.PI;
//            else if (shape is Triangle triangle) 
//                areas += 0.5 * triangle.Base * triangle.Height;
//        }
//        return areas;
//    }
//}


#endregion

#region Good example
Shape[] shapes = [
    new Rectangle(){Height = 34, Width = 30},
    new Rectangle(){Height = 78.3, Width = 15.6},
    new Circle(){Radius=36},
    new Rectangle(){Height = 7, Width = 22},
    new Triangle(){Height=25.6, Base=12},
    new Trapezoid(){Height = 5, SideA=10, SideB=15},
    new NeneminTendiri(){Faun = 25, Zafa = 13, Klabulet = 2}
    ];

Calculate calculate = new Calculate();
Console.WriteLine(calculate.Areas(shapes));

abstract class Shape
{
    public abstract double Area();
}

class Rectangle: Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area()=> Height * Width;
}

class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area() => Math.Pow(Radius, 2)* Math.PI;
}

class Triangle : Shape
{
    public double Height { get; set; }
    public double Base { get; set; }
    public override double Area() => 0.5 * Base * Height;
}

class Trapezoid : Shape
{
    public double SideA {  get; set; }
    public double SideB {  get; set; }
    public double Height { get; set; }
    public override double Area() => 0.5 * (SideA + SideB) * Height;
}

class NeneminTendiri : Shape
{
    public double Faun {  get; set; }
    public double Zafa { get; set; }
    public int Klabulet { get; set; }
    public override double Area()=>
        Math.Sin(Klabulet) / Math.Pow(Zafa, 3) + Faun;
    
}

class Calculate
{
    public double Areas(Shape[] shapes) 
                => shapes.Sum(sh => sh.Area());
}


#endregion
