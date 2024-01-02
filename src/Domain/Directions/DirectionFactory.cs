using Domain.Directions;

namespace Domain;

public class DirectionFactory
{
    public static IDirection CreateDirection(DirectionType direction)
    {
        if (direction == DirectionType.North)
            return new North();
        if (direction == DirectionType.East)
            return new East();
        if (direction == DirectionType.South)
            return new South();
        if (direction == DirectionType.West)
            return new West();
        else
            throw new NotSupportedException($"Invalid direction type: {direction.AsString()}");
        
    }
}
