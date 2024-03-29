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
    [InlineData("0:0:N", "0:1:N")]
    [InlineData("1:1:N", "1:2:N")]
    [InlineData("0:0:E", "1:0:E")]
    [InlineData("1:1:E", "2:1:E")]
    [InlineData("0:0:S", "0:-1:S")]
    [InlineData("1:1:S", "1:0:S")]
    [InlineData("0:0:W", "-1:0:W")]
    [InlineData("1:1:W", "0:1:W")]
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

    [Theory]
    [InlineData("0:0:N", "0:0:E")]
    [InlineData("0:0:E", "0:0:S")]
    [InlineData("0:0:S", "0:0:W")]
    [InlineData("0:0:W", "0:0:N")]
    public void Execute_RightCommand_ReturnsCorrectPosition(string startingPoint, string expectedEndingPoint)
    {
        // arrange
        var rightCommand = "R";
        var marsRovers = new MarsRovers(startingPoint);

        // act
        var result = marsRovers.Execute(rightCommand);

        // assert
        result.Should().Be(expectedEndingPoint);
    }

    [Theory]
    [InlineData("0:0:N", "0:0:W")]
    [InlineData("0:0:E", "0:0:N")]
    [InlineData("0:0:S", "0:0:E")]
    [InlineData("0:0:W", "0:0:S")]
    public void Execute_LeftCommand_ReturnsCorrectPosition(string startingPoint, string expectedEndingPoint)
    {
        // arrange
        var leftCommand = "L";
        var marsRovers = new MarsRovers(startingPoint);

        // act
        var result = marsRovers.Execute(leftCommand);

        // assert
        result.Should().Be(expectedEndingPoint);
    }

    [Theory]
    [InlineData("0:0:N", "FR", "0:1:E")]
    [InlineData("0:0:N", "FL", "0:1:W")]
    [InlineData("0:0:N", "FLRF", "0:2:N")]
    [InlineData("0:0:N", "FLRLRFF", "0:3:N")]
    [InlineData("0:0:N", "FRFRFRF", "0:0:W")]
    public void Execute_MultipleCommands_ReturnsCorrectPosition(string startingPoint, string commands, string expectedEndingPoint)
    {
        var marsRovers = new MarsRovers(startingPoint);

        // act
        var result = marsRovers.Execute(commands);

        // assert
        result.Should().Be(expectedEndingPoint);
    }
}