namespace Domain.Directions;

public class East : IDirection
{
    private Point point;
    private DirectionType directionType = DirectionType.East;

    public East(Point point) => this.point = point;

    public void MoveFoward() => point = new Point(point.X + 1, point.Y);

    public void MoveRight() => directionType = DirectionType.South;

    public string AsString() => $"{point.X}:{point.Y}:{GetDirection()}";

    public string GetDirection() => directionType.AsString();
}
