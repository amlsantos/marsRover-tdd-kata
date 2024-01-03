namespace Domain.Rovers.Directions;

public class West : IDirection
{
    private readonly DirectionType direction = DirectionType.West;

    public Point MoveFoward(Point position)
    {
        return new Point(position.X - 1, position.Y);
    }

    public IDirection MoveRight() => new North();
    public IDirection MoveLeft() => new South();

    public string AsString() => direction.AsString();
}
