namespace PongGame.util;

public class DeathZone(int x, int y, int width, int height, RectangularBoard board, PongGameEngine master) : IObstacle
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public int Width { get; set; } = width;
    public int Height { get; set; } = height;

    public RectangularBoard Board { get; private set; } = board;

    public PongGameEngine Master { get; private set; } = master;

    public void Affect(PongBall ball)
    {
        ball.Kill();
    }
}