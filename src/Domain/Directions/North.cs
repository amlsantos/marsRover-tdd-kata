using Domain.Directions;

namespace Domain;

public class North : IDirection
{
    private readonly DirectionType type = DirectionType.North;

    public Point MoveFoward(Point position)
    {
        return new Point(position.X, position.Y + 1);
    }

    public IDirection MoveRight() => new East();

    public IDirection MoveLeft() => new West();

    public string AsString() => type.AsString();
}