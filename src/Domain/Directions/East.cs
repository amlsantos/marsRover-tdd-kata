namespace Domain.Directions;

public class East : IDirection
{
    private Point position;
    private DirectionType direction = DirectionType.East;

    public East(Point point) => position = point;

    public void MoveFoward() => position = new Point(position.X + 1, position.Y);

    public void MoveRight() => direction = DirectionType.South;

    public void MoveLeft() => direction = DirectionType.North;

    public string AsString() => $"{position.X}:{position.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}
