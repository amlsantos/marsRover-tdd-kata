using Domain.Directions;

namespace Domain;

public class MarsRovers
{
    private readonly string _startingPointAsString;
    private Point position;
    private IDirection direction;

    public MarsRovers(string startingPoint)
    {
        _startingPointAsString = startingPoint;
        position = new Point(0, 0);
    }

    public string Execute(string command)
    {
        if (string.IsNullOrEmpty(command))
            return _startingPointAsString;
        
        position = GetStartingPoint();
        var directionType = GetStartingDirection();

        direction = DirectionFactory.CreateDirection(directionType);
        if (command == "F")
        {
            position = direction.MoveFoward(position);
        }
        if (command == "R")
        {
            direction = direction.MoveRight();
        }
        if (command == "L")
        {
            direction = direction.MoveLeft();
        }

        return direction.AsString(position);
    }

    private Point GetStartingPoint()
    {
        var splitInput = _startingPointAsString.Split(":").ToList();
        return new Point(int.Parse(splitInput[0]), int.Parse(splitInput[1]));
    }

    private DirectionType GetStartingDirection()
    {
        var splitInput = _startingPointAsString.Split(":").ToList();
        return DirectionType.Create(splitInput[2]);
    }
}
