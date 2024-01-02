using Domain.Directions;

namespace Domain;

internal class West : IDirection
{
    private Point position;
    private DirectionType direction = DirectionType.West;

    public West(Point point) => position = point;

    public void MoveFoward() => position = new Point(position.X - 1, position.Y);

    public void MoveRight() => direction = DirectionType.North;

    public void MoveLeft() => direction = DirectionType.South;

    public string AsString() => $"{position.X}:{position.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}
