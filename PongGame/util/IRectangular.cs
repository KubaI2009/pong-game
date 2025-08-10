namespace PongGame.util;

public interface IRectangular
{
    int X { get; }
    int Y { get; }
    int Width { get; }
    int Height { get; }
}

public static class IRectangularExtensions
{
    public static int West(this IRectangular rectangle)
    {
        return rectangle.X;
    }
    
    public static int North(this IRectangular rectangle)
    {
        return rectangle.Y;
    }
    
    public static int East(this IRectangular rectangle)
    {
        return rectangle.West() + rectangle.Width;
    }
    
    public static int South(this IRectangular rectangle)
    {
        return rectangle.North() + rectangle.Height;
    }

    public static bool Overlaps(this IRectangular rectangle, IRectangular other)
    {
        return rectangle.Overlaps(other.West(), other.North(), other.East(), other.South());
    }

    public static bool Overlaps(this IRectangular rectangle, int west, int north, int east, int south)
    {
        bool westOverlap = rectangle.West() >= west && rectangle.West() <= east;
        bool northOverlap = rectangle.North() >= north && rectangle.North() <= south;
        bool eastOverlap = rectangle.East() >= west && rectangle.East() <= east;
        bool southOverlap = rectangle.South() >= north && rectangle.South() <= south;
        
        return westOverlap || northOverlap || eastOverlap || southOverlap;
    }
    
    public static HashSet<CardinalDirection> GetHitDirections(this IRectangular obstacle, PongBall ball)
    {
        HashSet<CardinalDirection> directions = new HashSet<CardinalDirection>();
        int newWest = ball.West + ball.Velocity.X;
        int newNorth = ball.North + ball.Velocity.Y;
        int newEast = ball.East + ball.Velocity.X;
        int newSouth = ball.South + ball.Velocity.Y;

        if (!obstacle.Overlaps(newWest, newNorth, newEast, newSouth))
        {
            return directions;
        }

        if (newWest < obstacle.West())
        {
            directions.Add(CardinalDirection.West);
            Console.WriteLine("west");
        }

        if (newNorth < obstacle.North())
        {
            directions.Add(CardinalDirection.North);
            Console.WriteLine("north");
        }

        if (newEast > obstacle.East())
        {
            directions.Add(CardinalDirection.East);
            Console.WriteLine("east");
        }

        if (newSouth > obstacle.South())
        {
            directions.Add(CardinalDirection.South);
            Console.WriteLine("south");
        }
        
        return directions;
    }
}