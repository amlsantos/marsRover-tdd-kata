using Domain.Directions;

namespace Domain;

internal class West : IDirection
{
    // private Point position;
    private DirectionType direction = DirectionType.West;

    public Point MoveFoward(Point position)
    {
        return new Point(position.X - 1, position.Y);
    }

    public IDirection MoveRight()
    {
        direction = DirectionType.North;
        return new North();
    }

    public IDirection MoveLeft()
    {
        direction = DirectionType.South;
        return new South();
    }

    public string AsString(Point position) => $"{position.X}:{position.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}
