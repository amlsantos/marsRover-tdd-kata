
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
        var x = int.Parse(splitPoint[0]);
        var y = int.Parse(splitPoint[1]);
        var direction = splitPoint[2];

        if (command == "F")
        {
            if (IsNorth(direction))
                return MoveNorth(x, y, direction);
            if (IsEast(direction))
                return MoveEast(x, y, direction);
            if (IsSouth(direction))
                return MoveSouth(x, y, direction);
            if (IsWest(direction))
                return MoveWest(x, y, direction);
        }

        return string.Empty;
    }    

    private bool IsNorth(string direction)
    {
        return direction.Equals("N", StringComparison.InvariantCultureIgnoreCase);
    }

    private string MoveNorth(int x, int y, string direction)
    {
        return $"{x}:{y + 1}:{direction}";
    }

    private bool IsEast(string direction)
    {
        return direction.Equals("E", StringComparison.InvariantCultureIgnoreCase);
    }

    private string MoveEast(int x, int y, string direction)
    {
        return $"{x + 1}:{y}:{direction}";
    }

    private bool IsSouth(string direction)
    {
        return direction.Equals("S", StringComparison.InvariantCultureIgnoreCase);
    }

    private string MoveSouth(int x, int y, string direction)
    {
        return $"{x}:{y - 1}:{direction}";
    }

    private bool IsWest(string direction)
    {
        return direction.Equals("W", StringComparison.InvariantCultureIgnoreCase);
    }

    private string MoveWest(int x, int y, string direction)
    {
        return $"{x - 1}:{y}:{direction}";
    }
}
