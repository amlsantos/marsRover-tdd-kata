namespace Domain.Directions;

public class East : Direction
{
    private DirectionType type = DirectionType.East;

    public override Point MoveFoward(Point position) => new Point(position.X + 1, position.Y);

    public override Direction MoveRight() => new South();

    public override Direction MoveLeft() => new North();

    public override string AsString() => type.AsString();
}
