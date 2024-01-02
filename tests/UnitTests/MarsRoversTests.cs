using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class MarsRoversTests
{
    [Theory]
    [InlineData("0:0:N", "0:0:N")]
    public void Execute_NoCommand_RemainsInStartingPoint(string startingPoint, string expectedEndingPoint)
    {
        // arrange
        var marsRovers = new MarsRovers();

        // act
        var result = marsRovers.Execute(startingPoint);

        // assert
        result.Should().Be(expectedEndingPoint);
    }
}