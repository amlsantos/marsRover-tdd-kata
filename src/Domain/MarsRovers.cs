
namespace Domain;

public class MarsRovers
{
    private readonly string _startingPoint;

    public MarsRovers(string startingPoint) => _startingPoint = startingPoint;

    public string Execute(string command)
    {
        if (string.IsNullOrEmpty(command))
            return _startingPoint;

        var splitCommand = _startingPoint.Split(":").ToList();
        var x = int.Parse(splitCommand[0]);
        var y = int.Parse(splitCommand[1]);
        var direction = splitCommand[2];

        if (command == "F")
        {
            if (direction == "N")
                return $"{x}:{y+1}:{direction}";
        }

        return string.Empty;
    }
}
