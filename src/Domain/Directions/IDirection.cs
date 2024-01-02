namespace Domain.Directions;

public interface IDirection
{
    public abstract Point MoveFoward(Point position);
    public abstract IDirection MoveRight();
    public abstract IDirection MoveLeft();

    public abstract string AsString(Point position);
    public abstract string GetDirection();
}
