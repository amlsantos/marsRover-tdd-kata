using Domain.Rovers.Directions;

namespace Domain;

public static class RoverFactory
{
    public static Rover CreateFrom(string _positionAsString)
    {
        var position = GetStartingPoint(_positionAsString);
        var direction = GetStartingDirection(_positionAsString);

        return new Rover(position, direction);
    }

    private static Point GetStartingPoint(string _positionAsString)
    {
        var splitInput = _positionAsString.Split(":").ToList();
        return new Point(int.Parse(splitInput[0]), int.Parse(splitInput[1]));
    }

    private static IDirection GetStartingDirection(string _positionAsString)
    {
        var splitInput = _positionAsString.Split(":").ToList();
        var type = DirectionType.Create(splitInput[2]);

        return DirectionFactory.CreateDirection(type);
    }
}
