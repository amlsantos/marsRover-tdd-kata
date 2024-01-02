using Domain.Directions;

namespace Domain;

public class North : Direction
{
    private DirectionType type = DirectionType.North;

    public override Point MoveFoward(Point position)
    {
        return new Point(position.X, position.Y + 1);
    }

    public override Direction MoveRight() => new East();

    public override Direction MoveLeft() => new West();

    public override string AsString() => type.AsString();
}