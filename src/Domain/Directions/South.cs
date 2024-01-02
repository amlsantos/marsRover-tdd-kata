namespace Domain.Directions;

public class South : IDirection
{
    // private Point position;
    private DirectionType direction = DirectionType.South;

    public Point MoveFoward(Point position)
    {
        return new Point(position.X, position.Y - 1);
    }

    public IDirection MoveRight()
    {
        direction = DirectionType.West;
        return new West();        
    }

    public IDirection MoveLeft()
    {
        direction = DirectionType.East;
        return new East();
    }

    public string AsString(Point position) => $"{position.X}:{position.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}