using System.Numerics;

namespace MarsRoverKata;

public class Tests
{
    [Test]
    public void TestMovesInDirection()
    {
        var rover = new Rover(new Vector2(1, 1), Direction.N);
        rover.Move(new [] { Movement.F });

        Assert.Equals(rover.Location.X, 1);
        Assert.Equals(rover.Location.Y, 2);
    }
}