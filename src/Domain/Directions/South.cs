namespace Domain.Directions;

public class South : Direction
{
    private DirectionType type = DirectionType.South;

    public override Point MoveFoward(Point position)
    {
        return new Point(position.X, position.Y - 1);
    }

    public override Direction MoveRight() => new West();

    public override Direction MoveLeft() => new East();

    public override string AsString() => type.AsString();
}