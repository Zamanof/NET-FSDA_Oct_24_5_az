// See https://aka.ms/new-console-template for more information
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point()
        :this(default, default)
    { }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // operator overloading
    // Unary operators overloading
    
    //Unary -
    public static Point operator-(Point point) {
        return new(-point.X, -point.Y);
    }

    public static Point operator++(Point point)
    {
        point.X++;
        point.Y++;
        return point;
    }

    public static Point operator --(Point point)
    {
        point.X--;
        point.Y--;
        return point;
    }

    // Binary operators overloading
    public static Point operator+(Point left, Point right)
    {
        return new() { X = left.X + right.X, Y=left.Y+right.Y};
    }
    public static double operator -(Point left, Point right)
    {
        //Point tmp = new Point(left.X, right.X);
        return Math.Sqrt(Math.Pow(left.Y - right.Y, 2.0)+ Math.Pow(left.X - right.X, 2.0));
    }
    public static Point operator *(Point point, int value)
    {
        return new() { X = point.X * value, Y = point.Y * value };
    }
    public static Point operator *(int value, Point point)
    {
        return new() { X = point.X * value, Y = point.Y * value };
    }

    // comparison operators
    public override bool Equals(object? obj)
    {
        return this.ToString() == obj?.ToString();
    }
    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    public static bool operator ==(Point left, Point right)
    {
        return left.Equals(right);
    }
    public static bool operator !=(Point left, Point right)
    {
        return !(left ==right);
    }

    public static bool operator>(Point left, Point right)
    {
        return Math.Sqrt(Math.Pow(left.Y, 2.0) + Math.Pow(left.X, 2.0)) 
            > Math.Sqrt(Math.Pow(right.Y, 2.0) + Math.Pow(right.X, 2.0));
    }

    public static bool operator <(Point left, Point right)
    {
        return Math.Sqrt(Math.Pow(left.Y, 2.0) + Math.Pow(left.X, 2.0))
            < Math.Sqrt(Math.Pow(right.Y, 2.0) + Math.Pow(right.X, 2.0));
    }

    public static bool operator true(Point point) {
        return point.X != 0 || point.Y != 0;
    }
    public static bool operator false(Point point) {
        return point.X == 0 && point.Y == 0;
    }

    public static Point operator |(Point left, Point right)
    {
        if ((left.X != 0) || (left.Y != 0) || (right.X != 0) || (right.Y != 0))
        {
            return right;
        }
        return new();
    }

    public static Point operator &(Point left, Point right)
    {
        if ((left.X != 0) && (left.Y != 0) && (right.X != 0) && (right.Y != 0))
        {
            return right;
        }
        return new();
    }

    public override string ToString()
    {
        return $"Point ({X}, {Y})";
    }
}