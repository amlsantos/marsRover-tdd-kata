
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
            if (direction == "N")
                return $"{x}:{y+1}:{direction}";
            if (direction == "E")
                return $"{x+1}:{y}:{direction}";
            if (direction == "S")
                return $"{x}:{y-1}:{direction}";
            if (direction == "W")
                return $"{x-1}:{y}:{direction}";
        }

        return string.Empty;
    }
}
