
namespace Domain;

public class MarsRovers
{
    private readonly string _startingPoint;

    public MarsRovers(string startingPoint) => _startingPoint = startingPoint;

    public string Execute(string commands)
    {
        if (string.IsNullOrEmpty(commands))
            return _startingPoint;

        return string.Empty;
    }
}
