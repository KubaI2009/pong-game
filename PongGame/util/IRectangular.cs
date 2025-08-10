namespace PongGame.util;

public interface IRectangular
{
    int X { get; set; }
    int Y { get; set; }
    int Width { get; set; }
    int Height { get; set; }
}

public static class IRectangularExtensions
{
    public static int West(this IRectangular rectangular)
    {
        return rectangular.X;
    }
    
    public static int North(this IRectangular rectangular)
    {
        return rectangular.Y;
    }
    
    public static int East(this IRectangular rectangular)
    {
        return rectangular.West() + rectangular.Width;
    }
    
    public static int South(this IRectangular rectangular)
    {
        return rectangular.North() + rectangular.Height;
    }
}