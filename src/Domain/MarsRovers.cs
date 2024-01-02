
namespace Domain;

public class MarsRovers
{
    private readonly string _startingPoint;

    public MarsRovers(string startingPoint) => _startingPoint = startingPoint;

    public string Execute(string command)
    {
        if (string.IsNullOrEmpty(command))
            return _startingPoint;

        var splitPoint = _startingPoint.Split(":").ToList();
        var point = new Point(
            int.Parse(splitPoint[0]), int.Parse(splitPoint[1]));
        var direction = splitPoint[2];

        if (command == "F")
        {
            switch (direction)
            {
                case "N":
                    {
                        return MoveNorth(point, direction);
                    }

                case "E":
                    {
                        return MoveEast(point, direction);
                    }

                case "S":
                    {
                        return MoveSouth(point, direction);
                    }

                case "W":
                    {
                        return MoveWest(point, direction);
                    }
                default:
                    throw new NotSupportedException();
            }
        }

        return string.Empty;
    }

    private bool IsNorth(string direction)
    {
        return direction.Equals("N", StringComparison.InvariantCultureIgnoreCase);
    }

    private string MoveNorth(Point point, string direction)
    {
        var output = new Point(point.X, point.Y + 1);
        return AsString(direction, output);
    }

    private bool IsEast(string direction)
    {
        return direction.Equals("E", StringComparison.InvariantCultureIgnoreCase);
    }

    private string MoveEast(Point point, string direction)
    {
        var output = new Point(point.X + 1, point.Y);
        return AsString(direction, output);
    }

    private bool IsSouth(string direction)
    {
        return direction.Equals("S", StringComparison.InvariantCultureIgnoreCase);
    }

    private string MoveSouth(Point point, string direction)
    {
        var output = new Point(point.X, point.Y - 1);
        return AsString(direction, output);
    }

    private bool IsWest(string direction)
    {
        return direction.Equals("W", StringComparison.InvariantCultureIgnoreCase);
    }

    private string MoveWest(Point point, string direction)
    {
        var output = new Point(point.X - 1, point.Y);
        return AsString(direction, output);
    }

    private string AsString(string direction, Point output)
    {
        return $"{output.X}:{output.Y}:{direction}";
    }
}
