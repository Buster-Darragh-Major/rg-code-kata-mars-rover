using System.Numerics;

namespace MarsRoverKata;

public class Rover
{
    private readonly Vector<int> _startingPoint;
    private readonly Direction _direction;

    public Rover(Vector<int> startingPoint, Direction direction)
    {
        _startingPoint = startingPoint;
        _direction = direction;
    }

    public void Move(IEnumerable<Movement> movements)
    {
        
    }
}