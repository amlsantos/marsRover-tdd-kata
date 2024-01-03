using Domain.Directions;

namespace Domain;

public class MarsRovers
{
    private readonly string _positionAsString;
    private Point position;
    private IDirection direction;

    public MarsRovers(string startingPoint) => _positionAsString = startingPoint;

    public string Execute(string commandsAsString)
    {
        position = GetStartingPoint();
        direction = GetStartingDirection();

        if (string.IsNullOrEmpty(commandsAsString))
            return GetFinalPosition(position, direction);

        var commands = commandsAsString.ToCharArray();
        foreach (var command in commands)
        {
            if (command.Equals('F'))
            {
                position = direction.MoveFoward(position);
            }
            else if (command.Equals('R'))
            {
                direction = direction.MoveRight();
            }
            else if (command.Equals('L'))
            {
                direction = direction.MoveLeft();
            }
        }

        return GetFinalPosition(position, direction);
    }

    private Point GetStartingPoint()
    {
        var splitInput = _positionAsString.Split(":").ToList();
        return new Point(int.Parse(splitInput[0]), int.Parse(splitInput[1]));
    }

    private IDirection GetStartingDirection()
    {
        var splitInput = _positionAsString.Split(":").ToList();
        var type = DirectionType.Create(splitInput[2]);

        return DirectionFactory.CreateDirection(type);
    }

    private string GetFinalPosition(Point position, IDirection direction)
    {
        return $"{position.X}:{position.Y}:{direction.AsString()}";
    }
}
