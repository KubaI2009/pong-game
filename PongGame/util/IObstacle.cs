namespace PongGame.util;

public interface IObstacle : IRectangular
{
    void Affect(PongBall ball);
}