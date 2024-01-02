namespace Domain.Directions;

public class South : IDirection
{
    private Point point;

    public South(Point point) => this.point = point;

    public void MoveFoward()
    {
        point = new Point(point.X, point.Y - 1);
    }

    public string AsString()
    {
        return $"{point.X}:{point.Y}:{GetDirection()}";
    }

    public string GetDirection()
    {
        return "S";
    }
}