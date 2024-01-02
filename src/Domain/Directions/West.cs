using Domain.Directions;

namespace Domain;

public class West : Direction
{
    private DirectionType direction = DirectionType.West;

    public override Point MoveFoward(Point position)
    {
        return new Point(position.X - 1, position.Y);
    }

    public override Direction MoveRight() => new North();
    public override Direction MoveLeft() => new South();

    public override string AsString() => direction.AsString();
}
