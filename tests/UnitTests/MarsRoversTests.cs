using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class MarsRoversTests
{
    [Fact]
    public void Execute_NoCommand_RemainsInStartingPoint()
    {
        // arrange
        var startingPoint = "0:0:N";
        var marsRovers = new MarsRovers();

        // act
        var result = marsRovers.Execute(startingPoint);

        // assert
        result.Should().Be(startingPoint);
    }
}