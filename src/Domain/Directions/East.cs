namespace Domain.Directions;

public class East : IDirection
{
    private Point point;
    private string direction = "E";

    public East(Point point) => this.point = point;

    public void MoveFoward()
    {
        point = new Point(point.X + 1, point.Y);
    }

    public void MoveRight()
    {
        direction = "S";
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
