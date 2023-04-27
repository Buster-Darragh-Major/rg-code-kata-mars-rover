using System.Numerics;

namespace MarsRoverKata;

public class Tests
{
    [TestCase(Direction.N, 2,2,  new [] { Movement.F }, 2,3)]
    [TestCase(Direction.E, 2,2,  new [] { Movement.F }, 3,2)]
    [TestCase(Direction.S, 2,2,  new [] { Movement.F }, 2,1)]
    [TestCase(Direction.W, 2,2,  new [] { Movement.F }, 1,2)]
    [TestCase(Direction.N, 2,2,  new [] { Movement.B }, 2,1)]
    [TestCase(Direction.E, 2,2,  new [] { Movement.B }, 1,2)]
    [TestCase(Direction.S, 2,2,  new [] { Movement.B }, 2,3)]
    [TestCase(Direction.W, 2,2,  new [] { Movement.B }, 3,2)]
    
    public void TestMoveInDirection(Direction initDirection, int initX, int initY,
        IEnumerable<Movement> movements, int expectX, int expectY)
    {
        Vector2 initLocation = new Vector2(initX, initY);

        var rover = new Rover(initLocation, initDirection);
        rover.Move(movements);

        Assert.That(rover.Location.X, Is.EqualTo(expectX));
        Assert.That(rover.Location.Y, Is.EqualTo(expectY));
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