using System.Numerics;

namespace MarsRoverKata;

public class Tests
{
    [Test]
    public void TestMovesInDirection()
    {
        var rover = new Rover(new Vector2(1, 1), Direction.N);
        rover.Move(new [] { Movement.F });

        Assert.That(rover.Location.X, Is.EqualTo(1));
        Assert.That(rover.Location.Y, Is.EqualTo(2));
    }
    
    [TestCase(Direction.N, new [] { Movement.L }, Direction.W)]
    [TestCase(Direction.N, new [] { Movement.R }, Direction.E)]
    [TestCase(Direction.S, new [] { Movement.L }, Direction.E)]
    [TestCase(Direction.S, new [] { Movement.R }, Direction.W)]
    [TestCase(Direction.W, new [] { Movement.L }, Direction.S)]
    [TestCase(Direction.W, new [] { Movement.R }, Direction.N)]
    [TestCase(Direction.E, new [] { Movement.L }, Direction.N)]
    [TestCase(Direction.E, new [] { Movement.R }, Direction.S)]
    public void TestTurnsInDirection(Direction initDirection, IEnumerable<Movement> movements, Direction xVectorDirection)
    {
        var rover = new Rover(new Vector2(1, 1), initDirection);
        rover.Move(movements);

        Assert.That(rover.Location.X, Is.EqualTo(1));
        Assert.That(rover.Location.Y, Is.EqualTo(1));
        Assert.That(rover.Direction, Is.EqualTo(xVectorDirection));
    }
}