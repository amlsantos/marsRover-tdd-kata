namespace Domain.Directions;

public interface IDirection
{
    public abstract void MoveFoward();
    public abstract void MoveRight();
    public abstract string AsString();
    public abstract string GetDirection();
}
