using System.ComponentModel;

namespace PongGame.util;

public class PongBall : Label
{
    private static readonly int s_size = 15;
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public RectangularBoard Board { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Vector2Int Velocity { get; private set; }

    public int West
    {
        get { return Location.X; }
    }

    public int North
    {
        get { return Location.Y; }
    }

    public int East
    {
        get { return Location.X + Size.Width; }
    }

    public int South
    {
        get { return Location.Y + Size.Height; }
    }
    
    public PongBall(int startX, int startY, Vector2Int startVelocity, RectangularBoard board, PongGameEngine master) : base()
    {
        Size = new Size(s_size, s_size);
        Location = new Point(board.X + startX, board.Y + startY - Size.Width / 2);
        BackColor = Color.White;
        Board = board;
        Velocity = startVelocity;
        
        master.Controls.Add(this);
    }

    public void Update()
    {
        CardinalDirection[] hitDirections = HitDirections();
        
        foreach (CardinalDirection direction in hitDirections)
        {
            Velocity.EntrywiseMultiply(direction.ReflectionCoefficient);
        }
        
        Move();
    }

    public CardinalDirection[] HitDirections()
    {
        List<CardinalDirection> directions = new List<CardinalDirection>();
        int newWest = West + Velocity.X;
        int newNorth = North + Velocity.Y;
        int newEast = East + Velocity.X;
        int newSouth = South + Velocity.Y;

        if (newWest < Board.West())
        {
            directions.Add(CardinalDirection.West);
            Console.WriteLine("west");
        }

        if (newNorth < Board.North())
        {
            directions.Add(CardinalDirection.North);
            Console.WriteLine("north");
        }

        if (newEast > Board.East())
        {
            directions.Add(CardinalDirection.East);
            Console.WriteLine("east");
        }

        if (newSouth > Board.South())
        {
            directions.Add(CardinalDirection.South);
            Console.WriteLine("south");
        }
        
        return directions.ToArray();
    }

    public void Move()
    {
        Location = new Point(Location.X + Velocity.X, Location.Y + Velocity.Y);
    }

    public void SpeedUp(int coefficient)
    {
        Velocity.Scale(coefficient);
    }
}