using Domain.Directions;

namespace Domain;

public class North : IDirection
{
    private Point point;
    private DirectionType direction = DirectionType.North;

    public North(Point point) => this.point = point;

    public void MoveFoward() => point = new Point(point.X, point.Y + 1);

    public void MoveRight() => direction = DirectionType.East;

    public void MoveLeft() => direction = DirectionType.West;

    public string AsString() => $"{point.X}:{point.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}