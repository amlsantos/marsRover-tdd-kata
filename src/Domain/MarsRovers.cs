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
        var directionAsString = GetStartingDirection();

        var direction = DirectionFactory.CreateDirection(point, directionAsString);
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

    private string GetStartingDirection()
    {
        var splitInput = _startingPointAsString.Split(":").ToList();
        return splitInput[2];
    }
}
