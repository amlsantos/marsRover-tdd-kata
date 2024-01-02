using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class MarsRoversTests
{
    [Theory]
    [InlineData("0:0:N", "0:0:N")]
    [InlineData("1:1:N", "1:1:N")]
    public void Execute_NoCommand_RemainsInStartingPoint(string startingPoint, string expectedEndingPoint)
    {
        // arrange
        var emptyCommand = string.Empty;
        var marsRovers = new MarsRovers(startingPoint);

        // act
        var result = marsRovers.Execute(emptyCommand);

        // assert
        result.Should().Be(expectedEndingPoint);
    }

    [Theory]
    [InlineData("0:0:N", "0:0:N")]
    [InlineData("1:1:N", "1:2:N")]
    public void Execute_FowardCommand_ReturnsCorrectPosition(string startingPoint, string expectedEndingPoint)
    {
        // arrange
        var fowardCommand = "F";
        var marsRovers = new MarsRovers(startingPoint);

        // act
        var result = marsRovers.Execute(fowardCommand);

        // assert
        result.Should().Be(expectedEndingPoint);
    }
}