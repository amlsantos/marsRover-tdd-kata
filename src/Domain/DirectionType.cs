using System.Net.Http.Headers;

namespace Domain;

public class DirectionType
{
    public static readonly DirectionType North = new("N");
    public static readonly DirectionType South = new("S");
    public static readonly DirectionType  West = new("W");
    public static readonly DirectionType  East = new("E");

    private readonly string _value;

    public DirectionType(string displayName) => _value = displayName;

    public string AsString() => _value;
}
