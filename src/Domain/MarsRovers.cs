namespace Domain;

public class MarsRovers
{
    private readonly string _startingPointAsString;

    public MarsRovers(string startingPoint) => _startingPointAsString = startingPoint;

    public string Execute(string command)
    {
        if (string.IsNullOrEmpty(command))
            return _startingPointAsString;
        
        var point = GetStartingPoint();
        var directionType = GetStartingDirection();

        var direction = DirectionFactory.CreateDirection(point, directionType);
        if (command == "F")
        {
            direction.MoveFoward();
            return direction.AsString();
        }
        if (command == "R")
        {
            direction.MoveRight();
            return direction.AsString();
        }
        if (command == "L")
        {
            direction.MoveLeft();
            return direction.AsString();
        }

        return string.Empty;
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
