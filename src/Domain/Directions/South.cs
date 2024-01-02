namespace Domain.Directions;

public class South : IDirection
{
    private Point position;
    private DirectionType direction = DirectionType.South;

    public South(Point point) => position = point;

    public void MoveFoward() => position = new Point(position.X, position.Y - 1);

    public void MoveRight() => direction = DirectionType.West;

    public void MoveLeft() => direction = DirectionType.East;

    public string AsString() => $"{position.X}:{position.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}