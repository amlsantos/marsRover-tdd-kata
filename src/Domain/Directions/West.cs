using Domain.Directions;

namespace Domain;

internal class West : IDirection
{
    private Point point;
    private DirectionType direction = DirectionType.West;


    public West(Point point) => this.point = point;

    public void MoveFoward() => point = new Point(point.X - 1, point.Y);

    public void MoveRight() => direction = DirectionType.North;

    public void MoveLeft() => direction = DirectionType.South;

    public string AsString() => $"{point.X}:{point.Y}:{GetDirection()}";

    public string GetDirection() => direction.AsString();
}
