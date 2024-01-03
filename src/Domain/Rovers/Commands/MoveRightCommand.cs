namespace Domain;

public class MoveRightCommand : ICommand
{
    private readonly Rover _rover;

    public MoveRightCommand(Rover rover) => _rover = rover;

    public Rover Execute() => _rover.MoveRight();
}
