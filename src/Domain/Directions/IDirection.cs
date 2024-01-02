namespace Domain.Directions;

public interface IDirection
{
    public abstract void MoveFoward();
    public abstract string AsString();
    public abstract string GetDirection();
}
