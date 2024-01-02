using Domain.Directions;

namespace Domain;

public class North : IDirection
{
    private Point point;

    public North(Point point) => this.point = point;

    public void MoveFoward()
    {
        point = new Point(point.X, point.Y + 1);
    }

    public string AsString()
    {
        return $"{point.X}:{point.Y}:{GetDirection()}";
    }

    public string GetDirection()
    {
        return "N";
    }
}