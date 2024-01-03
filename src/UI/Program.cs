using Domain;

var startingPosition = "0:0:N";
var marsRover = new MarsRovers(startingPosition);

var commands = "FRFRFRF";
var finalPOsition = marsRover.Execute(commands);

Console.WriteLine("-------------" + finalPOsition);
