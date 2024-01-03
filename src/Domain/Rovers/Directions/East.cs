using Domain.Directions;

namespace Domain.Rovers.Directions;

public class East : IDirection
{
    private readonly DirectionType type = DirectionType.East;

    public Point MoveFoward(Point position)
    {
        return new Point(position.X + 1, position.Y);
    }

    public IDirection MoveRight() => new South();

    public IDirection MoveLeft() => new North();

    public string AsString() => type.AsString();
}
