using Domain.Directions;

namespace Domain;

public class DirectionFactory
{
    public static IDirection CreateDirection(Point point, string directionAsString)
    {
        switch (directionAsString)
        {
            case "N":
                return new North(point);
            case "E":
                return new East(point);
            case "S":
                return new South(point);
            case "W":
                return new Weast(point);
            default:
                throw new NotSupportedException();
        }
    }
}
