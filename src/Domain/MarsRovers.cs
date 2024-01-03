using Domain.Rovers.Directions;

namespace Domain;

public class MarsRovers
{
    private readonly string _initialState;
    
    public MarsRovers(string startingPoint)
    {
        _initialState = startingPoint;
    }

    public string Execute(string commandsAsString)
    {
        if (string.IsNullOrEmpty(commandsAsString))
            return _initialState;

        var rover = RoverFactory.CreateFrom(_initialState);

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
}
