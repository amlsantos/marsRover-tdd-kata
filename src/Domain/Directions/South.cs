namespace Domain.Directions;

public class South : IDirection
{
    private readonly DirectionType type = DirectionType.South;

    public Point MoveFoward(Point position)
    {
        return new Point(position.X, position.Y - 1);
    }

    public IDirection MoveRight() => new West();

    public IDirection MoveLeft() => new East();

    public string AsString() => type.AsString();
}