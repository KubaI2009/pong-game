namespace PongGame.util;

public class RectangularBoard : IRectangular
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public PongGameEngine Master { get; private set; }

    public RectangularBoard(int x, int y, int width, int height, PongGameEngine master)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        Master = master;
    }
}