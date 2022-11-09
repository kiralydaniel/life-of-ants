namespace Codecool.LifeOfAnts.Ants;

public class AntSoldier : Ant
{
    private Direction faceDirection;

    public AntSoldier(Position position) : base(position)
    {
        faceDirection = Direction.North;
    }

    public override void Act(int width)
    {
        var direction = faceDirection;
        var nextPosition = Util.MakeNextMovePosition(direction, Position);
        if (Util.IsPositionValid(nextPosition, width))
        {
            Position = nextPosition;
        }

        if ((int)direction == 3)
        {
            faceDirection = Direction.North;
        }
        else
        {
            faceDirection = (Direction)((int)direction + 1);
        }
    }

    public override string ToString()
    {
        return "S ";
    }
}