namespace Domain;

public class MoveFowardCommand : ICommand
{
    private readonly Rover _rover;

    public MoveFowardCommand(Rover rover) => _rover = rover;

    public Rover Execute() => _rover.MoveFoward();
}
