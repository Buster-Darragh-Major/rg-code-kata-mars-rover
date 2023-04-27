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
                case Movement.B:
                    Location += GetMovementVector(movement);
                    break;
                case Movement.L:
                case Movement.R:
                    Direction = Turn(movement);
                    break;
            }
        }
    }

    private Vector2 GetMovementVector(Movement movement)
    {
        Vector2 vector;
        switch (Direction)
        {
            case Direction.N:
                vector = new Vector2(0, 1);
                break;
            case Direction.E:
                vector = new Vector2(1, 0);
                break;
            case Direction.S:
                vector = new Vector2(0, -1);
                break;
            case Direction.W:
                vector = new Vector2(-1, 0);
                break;
            default:
                vector = new Vector2();
                break;
        }

        return movement == Movement.F ? vector : vector * new Vector2(-1, -1);
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