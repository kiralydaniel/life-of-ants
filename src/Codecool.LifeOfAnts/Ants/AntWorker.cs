using System.Threading;

namespace Codecool.LifeOfAnts.Ants;

public class AntWorker : Ant
{
    public AntWorker(Position position) : base(position)
    {
    }

    public override void Act(int width)
    {
        var direction = (Direction)Util.PickRandomNumber(0, 4);
        var nextPosition = Util.MakeNextMovePosition(direction, Position);
        if (Util.IsPositionValid(nextPosition, width))
        {
            Position = nextPosition;
        }
    }

    public override string ToString()
    {
        return "W ";
    }
}