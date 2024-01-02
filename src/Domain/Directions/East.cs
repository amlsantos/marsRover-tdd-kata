namespace Domain.Directions;

public class East : IDirection
{
    // private Point position;
    private DirectionType direction = DirectionType.East;

    public Point MoveFoward(Point position) => new Point(position.X + 1, position.Y);

    public IDirection MoveRight()
    {
        return new South();

        direction = DirectionType.South;
    }

    public IDirection MoveLeft()
    {
        return new North();
        direction = DirectionType.North;
    }

    public string AsString(Point position) => $"{position.X}:{position.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}
