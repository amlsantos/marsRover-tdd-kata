namespace Domain;

public class Point
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Point(Point point)
    {
        X = point.X;
        Y = point.Y;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void IncreaseY()
    {
        Y += 1;
    }

    public void DecreaseY()
    {
        Y -= 1;
    }

    public void IncreaseX()
    {
        X += 1;
    }

    public void DecreaseX()
    {
        X -= 1;
    }
}
