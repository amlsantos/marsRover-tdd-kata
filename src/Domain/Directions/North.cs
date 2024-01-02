using Domain.Directions;

namespace Domain;

public class North : IDirection
{
    private Point position;
    private DirectionType direction = DirectionType.North;

    public North(Point point) => position = point;

    public void MoveFoward() => position = new Point(position.X, position.Y + 1);

    public void MoveRight() => direction = DirectionType.East;

    public void MoveLeft() => direction = DirectionType.West;

    public string AsString() => $"{position.X}:{position.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}