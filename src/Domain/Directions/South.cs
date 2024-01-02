namespace Domain.Directions;

public class South : IDirection
{
    private Point point;
    private DirectionType direction = DirectionType.South;

    public South(Point point) => this.point = point;

    public void MoveFoward() => point = new Point(point.X, point.Y - 1);

    public void MoveRight() => direction = DirectionType.West;

    public string AsString() => $"{point.X}:{point.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}