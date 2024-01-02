using Domain.Directions;

namespace Domain;

public class DirectionFactory
{
    public static IDirection CreateDirection(Point point, DirectionType direction)
    {
        if (direction == DirectionType.North)
            return new North(point);
        if (direction == DirectionType.East)
            return new East(point);
        if (direction == DirectionType.South)
            return new South(point);
        if (direction == DirectionType.West)
            return new West(point);
        else
            throw new NotSupportedException($"Invalid direction type: {direction.AsString()}");
        
    }
}
