using Domain.Rovers.Directions;

namespace Domain;

public class Rover
{
    private readonly Point _position;
    private readonly IDirection _direction;

    public Rover(Point position, IDirection direction)
    {
        _position = position;
        _direction = direction;
    }

    public Rover MoveFoward()
    {
        var foward = _direction.MoveFoward(_position);
        return new Rover(foward, _direction);
    }

    public Rover MoveRight()
    {
        var right = _direction.MoveRight();
        return new Rover(_position, right);
    }

    public Rover MoveLeft()
    {
        var left = _direction.MoveLeft();
        return new Rover(_position, left);
    }

    public string GetFinalPosition()
    {
        return $"{_position.X}:{_position.Y}:{_direction.AsString()}";
    }
}
