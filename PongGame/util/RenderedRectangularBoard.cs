namespace PongGame.util;

public class RenderedRectangularBoard : Label
{
    public RenderedRectangularBoard(int x, int y, int width, int height) : base()
    {
        Location = new Point(x, y);
        Size = new Size(width, height);
        BackColor = Color.Black;
    }
}