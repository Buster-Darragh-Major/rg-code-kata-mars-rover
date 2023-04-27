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
            switch (movement)
            {
                case Movement.F:
                    Location += new Vector2(0, 1);
                    break;
                case Movement.B:
                    Location += new Vector2(0, -1);
                    break;
                case Movement.L:
                case Movement.R:
                    Direction = Turn(movement);
                    break;
            }
        }
    }

    private Direction Turn(Movement movement)
    {
        switch (Direction)
        {
            case Direction.N :
                return movement == Movement.L ? Direction.W : Direction.E;
            case Direction.S :
                return movement == Movement.L ? Direction.E : Direction.W;  
            case Direction.E :
                return movement == Movement.L ? Direction.N : Direction.S; 
            case Direction.W :
                return movement == Movement.L ? Direction.S : Direction.N; 
            default:
                return Direction;
        }
    }
}