namespace OperatorsOverride;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }


    public Point()
    {
        
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static bool operator true(Point a)
    {
        return a.X != 0 || a.Y != 0 ? true : false;
    }
    
    public static bool operator false(Point a)
    {
        return a.X == 0 || a.Y == 0 ? true : false;
    }

    public static Point operator |(Point a, Point b)
    {
        if ((a.X != 0 || b.X != 0) || (a.Y != 0 || b.Y != 0))
        {
            return b;
        }
        return new Point();
    }
    
    public static Point operator &(Point a, Point b)
    {
        if ((a.X != 0 && b.X != 0) && (a.Y != 0 && b.Y != 0))
            return b;
        return new Point();
    }
    

    public override bool Equals(object obj)
    {
        return this.ToString() == obj.ToString();
    }

    public static bool operator ==(Point a, Point b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }

    public static Point operator ++(Point a)
    {
        a.X++;
        a.Y++;
        return a;
    }
    
    public static Point operator --(Point a)
    {
        a.X--;
        a.Y--;
        return a;
    }

    public static Point operator +(Point a, Point b)
    {
        return new Point
        {
            X = a.X + b.X,
            Y = a.Y + b.Y
        };
    }

    public static Point operator -(Point a)
    {
        return new Point {X = -a.X, Y = -a.Y};
    }

    public override string ToString()
    {
        return $"coord X: {this.X} coord Y: {this.Y}";
    }
}