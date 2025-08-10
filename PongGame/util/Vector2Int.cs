namespace PongGame.util;

public class Vector2Int(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public void RotateClockwise()
    {
        int t = X;
        
        X = Y;
        Y = -t;
    }

    public void RotateCounterClockwise()
    {
        int t = X;
        
        X = -Y;
        Y = t;
    }

    public void TurnAround()
    {
        Scale(-1);
    }

    public void Reflect(CardinalDirection direction)
    {
        EntrywiseMultiply(direction.ReflectionCoefficient);
    }

    public void Add(Vector2Int other)
    {
        X += other.X;
        Y += other.Y;
    }

    public void Scale(int coefficient)
    {
        X *= coefficient;
        Y *= coefficient;
    }

    public void EntrywiseMultiply(Vector2Int other)
    {
        X *= other.X;
        Y *= other.Y;
    }

    public static Vector2Int Sum(Vector2Int v, Vector2Int u)
    {
        return new Vector2Int(v.X + u.X, v.Y + u.Y);
    }

    public static Vector2Int Scaled(Vector2Int v, int coefficient)
    {
        return new Vector2Int(v.X * coefficient, v.Y * coefficient);
    }

    public static Vector2Int EntrywiseProduct(Vector2Int v, Vector2Int u)
    {
        return new Vector2Int(v.X * u.X, v.Y * u.Y);
    }
}