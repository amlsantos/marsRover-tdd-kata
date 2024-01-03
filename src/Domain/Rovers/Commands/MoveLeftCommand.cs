namespace Domain;

public class MoveLeftCommand : ICommand
{
    private readonly Rover _rover;

    public MoveLeftCommand(Rover rover) => _rover = rover;

    public Rover Execute() => _rover.MoveLeft();
}
