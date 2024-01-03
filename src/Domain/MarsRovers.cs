using Domain.Rovers.Directions;

namespace Domain;

public class MarsRovers
{
    private readonly string _initialState;
    private Rover rover;
    public MarsRovers(string startingPoint) => _initialState = startingPoint;

    public string Execute(string commandsAsString)
    {
        if (string.IsNullOrEmpty(commandsAsString))
            return _initialState;

        rover = CreateFrom(_initialState);

        var commands = commandsAsString.ToCharArray();
        foreach (var command in commands)
        {
            if (command.Equals('F'))
            {
                rover = rover.MoveFoward();
                // position = direction.MoveFoward(position);
            }
            else if (command.Equals('R'))
            {
                rover = rover.MoveRight();
                // direction = direction.MoveRight();
            }
            else if (command.Equals('L'))
            {
                rover = rover.MoveLeft();
                // direction = direction.MoveLeft();
            }


            // OLd(ref position, ref direction, command);
        }

        return rover.GetFinalPosition();
    }

    public Rover CreateFrom(string _positionAsString)
    {
        var position = GetStartingPoint(_positionAsString);
        var direction = GetStartingDirection(_positionAsString);

        return new Rover(position, direction);
    }

    private Point GetStartingPoint(string _positionAsString)
    {
        var splitInput = _positionAsString.Split(":").ToList();
        return new Point(int.Parse(splitInput[0]), int.Parse(splitInput[1]));
    }

    private IDirection GetStartingDirection(string _positionAsString)
    {
        var splitInput = _positionAsString.Split(":").ToList();
        var type = DirectionType.Create(splitInput[2]);

        return DirectionFactory.CreateDirection(type);
    }
}
