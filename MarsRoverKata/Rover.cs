using System.Numerics;

namespace MarsRoverKata;

public class Rover
{
    public Vector2 Location { get; set; }
    public Direction Direction { get; set; }

    public Rover(Vector2 location, Direction direction)
    {
        Location = location;
        Direction = direction;
    }

    public void Move(IEnumerable<Movement> movements)
    {
        foreach (var movement in movements)
        {
            if (Direction == Direction.N)
            {
                Location += new Vector2(0, 1);
            }
        }
    }
}