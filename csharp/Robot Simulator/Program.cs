public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    private int y;
    private int x;
    private Direction direction;
    public RobotSimulator(Direction direction, int x, int y)
    {
        this.direction = direction;
        this.x = x;
        this.y = y;
    }

    public Direction Direction
    {
        get
        {
            return direction;
        }
    }

    public int X
    {
        get
        {
            return x;
        }
    }

    public int Y
    {
        get
        {
            return y;
        }
    }

    public void Move(string instructions)
    {
        foreach(char c in instructions)
        {
            switch (c)
            {
                case 'R': 
                    direction = (Direction)(((int)Direction + 1) % 4);
                    break;

                case 'L':
                    direction = (Direction)(((int)Direction + 3) % 4);
                    break;

                case 'A':
                    switch(direction)
                    {
                        case Direction.North: y++; break;
                        case Direction.South: y--; break;
                        case Direction.East: x++; break;
                        case Direction.West: x--; break;
                    }
                    break;

                default: throw new ArgumentException("Wrong Input");
            }
        }
    }
}