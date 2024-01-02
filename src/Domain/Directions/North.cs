using Domain.Directions;

namespace Domain;

public class North : IDirection
{
    // private Point position;
    private DirectionType direction = DirectionType.North;

    public Point MoveFoward(Point position)
    {
        return new Point(position.X, position.Y + 1);
    }

    public IDirection MoveRight()
    {
        return new East();
    }

    public IDirection MoveLeft()
    {
        direction = DirectionType.West;
        return new West();
    }

    public string AsString(Point position)
    {
        return $"{position.X}:{position.Y}:{GetDirection()}";
    }

    public string GetDirection() => direction.AsString();
}