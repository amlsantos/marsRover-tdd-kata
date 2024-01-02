using Domain.Directions;

namespace Domain;

public class North : IDirection
{
    private Point point;
    private string direction = "N";

    public North(Point point) => this.point = point;

    public void MoveFoward()
    {
        point = new Point(point.X, point.Y + 1);
    }

    public void MoveRight()
    {
        direction = "E";
    }

    public string AsString()
    {
        return $"{point.X}:{point.Y}:{GetDirection()}";
    }

    public string GetDirection()
    {
        return direction;
    }
}