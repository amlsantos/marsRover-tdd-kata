using Domain.Directions;

namespace Domain;

public class MarsRovers
{
    private readonly string _startingPointAsString;

    public MarsRovers(string startingPoint) => _startingPointAsString = startingPoint;

    public string Execute(string command)
    {
        if (string.IsNullOrEmpty(command))
            return _startingPointAsString;

        var splitPoint = _startingPointAsString.Split(":").ToList();
        var point = new Point(int.Parse(splitPoint[0]), int.Parse(splitPoint[1]));
        var directionAsString = splitPoint[2];

        var direction = DirectionFactory.CreateDirection(point, directionAsString);
        if (command == "F")
        {
            direction.MoveFoward();
            return direction.AsString();
        }

        return string.Empty;
    }
}
