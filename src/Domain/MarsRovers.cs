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

        foreach (var c in commands)
        {
            var command = CreateCommand(rover, c);
            rover = rover.Apply(command);
            // rover = command.Execute();
        }

        return rover.GetFinalPosition();
    }

    private ICommand CreateCommand(Rover rover, char command)
    {
        if (command.Equals('F'))
        {
            return new MoveFowardCommand(rover);
        }
        else if (command.Equals('R'))
        {
            return new MoveRightCommand(rover);
        }
        else if (command.Equals('L'))
        {
            return new MoveLeftCommand(rover);
        }

        throw new NotSupportedException($"Not supported command: {command}");
    }
}
