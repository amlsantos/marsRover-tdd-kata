using Domain.Directions;

namespace Domain;

internal class Weast : IDirection
{
    private Point point;
    private const string direction = "W";


    public Weast(Point point)
    {
        this.point = point;
    }

    public void MoveFoward()
    {
        point = new Point(point.X - 1, point.Y);
    }

    public string AsString()
    {
        return $"{point.X}:{point.Y}:{GetDirection()}";
    }

    public string GetDirection()
    {
        return "W";
    }
}
