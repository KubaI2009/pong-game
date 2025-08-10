using System.Numerics;

namespace PongGame.util;

public class CardinalDirection
{
    public static CardinalDirection West = new CardinalDirection(new Vector2Int(-1, 0));
    public static CardinalDirection North = new CardinalDirection(new Vector2Int(0, -1));
    public static CardinalDirection East = new CardinalDirection(new Vector2Int(1, 0));
    public static CardinalDirection South = new CardinalDirection(new Vector2Int(0, 1));
    
    public Vector2Int NormalizedVelocity { get; private set; }

    public Vector2Int ReflectionCoefficient
    {
        get
        {
            int x = NormalizedVelocity.X == 0 ? 1 : -1;
            int y = NormalizedVelocity.Y == 0 ? 1 : -1;
            
            return new Vector2Int(x, y);
        }
    }

    private CardinalDirection(Vector2Int normalizedVelocity)
    {
        NormalizedVelocity = normalizedVelocity;
    }
}