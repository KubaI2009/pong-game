namespace PongGame.util;

public class RectangularBoard : IRectangular
{
    private static readonly List<IRectangular> s_emptyList = new List<IRectangular>();
    
    public int X
    {
        get;
        set;
    }

    public int Y
    {
        get;
        set;
    }

    public int Width
    {
        get;
        set;
    }

    public int Height
    {
        get;
        set;
    }

    public PongGameEngine Master
    {
        get;
        private set;
    }

    public List<IRectangular> Obstacles
    {
        get;
        private set;
    }

    //s_emptyList exists because the other constructor creates a shallow copy of obstacles anyways
    //there is no point in creating an empty list every time
    //so I just made it a static field
    public RectangularBoard(int x, int y, int width, int height, PongGameEngine master) :
        this(x, y, width, height, s_emptyList, master)
    {
        
    }

    public RectangularBoard(int x, int y, int width, int height, List<IRectangular> obstacles, PongGameEngine master)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        Master = master;
        Obstacles = obstacles.GetRange(0, obstacles.Count);
    }

    public void AddObstacle(IRectangular obstacle)
    {
        Obstacles.Add(obstacle);
    }
}