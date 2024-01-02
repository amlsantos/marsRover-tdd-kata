using System.Net.Http.Headers;

namespace Domain;

public class DirectionType
{
    public static readonly DirectionType North = new("N");
    public static readonly DirectionType South = new("S");
    public static readonly DirectionType West = new("W");
    public static readonly DirectionType East = new("E");

    private readonly string _value;

    private DirectionType(string displayName) => _value = displayName;

    public static DirectionType Create(string value)
    {
        switch (value)
        {
            case "N":
                return North;
            case "S":
                return South;
            case "W":
                return West;
            case "E":
                return East;
            default:
                throw new NotSupportedException();
        }
    }

    public string AsString() => _value;
}
