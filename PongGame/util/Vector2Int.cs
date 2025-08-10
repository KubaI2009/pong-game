namespace PongGame.util;

public class Vector2Int(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public void SwapCoordinates()
    {
        (X, Y) = (Y, X);
    }

    public void RotateClockwise()
    {
        SwapCoordinates();
        EntrywiseMultiply(1, -1);
    }

    public void RotateCounterClockwise()
    {
        SwapCoordinates();
        EntrywiseMultiply(-1, 1);
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
        Add(other.X, other.Y);
    }

    public void Add(int x, int y)
    {
        X += x;
        Y += y;
    }

    public void Scale(int coefficient)
    {
        X *= coefficient;
        Y *= coefficient;
    }

    public void EntrywiseMultiply(Vector2Int other)
    {
        EntrywiseMultiply(other.X, other.Y);
    }

    public void EntrywiseMultiply(int x, int y)
    {
        X *= x;
        Y *= y;
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