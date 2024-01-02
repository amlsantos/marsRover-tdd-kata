using Domain.Directions;

namespace Domain;

public class MarsRovers
{
    private readonly string _positionAsString;

    public MarsRovers(string startingPoint) => _positionAsString = startingPoint;

    public string Execute(string commandsAsString)
    {
        var position = GetStartingPoint();
        var direction = GetStartingDirection();

        if (string.IsNullOrEmpty(commandsAsString))
            return PrintFinalPosition(position, direction);

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

        return PrintFinalPosition(position, direction);
    }

    private Point GetStartingPoint()
    {
        var splitInput = _positionAsString.Split(":").ToList();
        return new Point(int.Parse(splitInput[0]), int.Parse(splitInput[1]));
    }

    private Direction GetStartingDirection()
    {
        var splitInput = _positionAsString.Split(":").ToList();
        var type = DirectionType.Create(splitInput[2]);

        return DirectionFactory.CreateDirection(type);
    }

    private string PrintFinalPosition(Point position, Direction direction)
    {
        return $"{position.X}:{position.Y}:{direction.AsString()}";
    }
}
