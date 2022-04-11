namespace OperatorsOverride;

public abstract class Figure
{
    
}

public abstract class Quadrangle : Figure
{
}

public class Rectangle : Quadrangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public static implicit operator Rectangle(Square s)
    {
        return new Rectangle { Width = s.Length * 2, Height = s.Length};
    }
    
    public override string ToString()
    {
        return $"Rectangle: Width - {Width}; Height - {Height}";
    }
}

public class Square : Quadrangle
{
    public int Length { get; set; }

    public static explicit operator int(Square s)
    {
        return s.Length;
    }

    public static explicit operator Square(Rectangle rect)
    {
        return new Square {Length = rect.Height};
    }

    public static implicit operator Square(int a)
    {
        return new Square {Length = a};
    }
    
    public override string ToString()
    {
        return $"Square: Lenght - {Length}";
    }
}