namespace Domain.Directions;

public abstract class Direction
{
    public abstract Point MoveFoward(Point position);
    public abstract Direction MoveRight();
    public abstract Direction MoveLeft();

    public abstract string AsString();
}
