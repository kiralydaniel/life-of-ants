using System;
using System.Collections.Generic;
using System.Threading;

namespace Codecool.LifeOfAnts.Ants;

public class AntDrone : Ant
{
    private AntQueen _queen;
    private int _isMatingCounter;
    public AntDrone(Position position, AntQueen queen) : base(position)
    {
        _queen = queen;
        _isMatingCounter = 0;
    }

    public override void Act(int width)
    {
        if (_isMatingCounter == 0)
        {
            if (!IsDroneAtQueenPosition())
            {
                MoveCloserToQueen();
            }
            else
            {
                if (_queen.IsReadyToMate)
                {
                    _isMatingCounter = 10;
                    _queen.IsReadyToMate = false;
                    _queen.MatingMoodCounter = Util.PickRandomNumber(50, 100);
                    Console.WriteLine("HALLELUJAH");
                }
                else
                {
                    GetKickedToBorder();
                }
            }
        }
        else
        {
            _isMatingCounter--;
            if (_isMatingCounter == 0)
            {
                GetKickedToBorder();
            }
        }
    }

    private List<Direction> GetPossibleDirections()
    {
        var possibleDirections = new List<Direction>();
        if (Position.X < _queen.Position.X)
        {
            possibleDirections.Add(Direction.South);
        }

        if (Position.X > _queen.Position.X)
        {
            possibleDirections.Add(Direction.North);
        }

        if (Position.Y < _queen.Position.Y)
        {
            possibleDirections.Add(Direction.East);
        }

        if (Position.Y > _queen.Position.Y)
        {
            possibleDirections.Add(Direction.West);
        }

        return possibleDirections;
    }

    private bool IsDroneAtQueenPosition()
    {
        return Position.X == _queen.Position.X && Position.Y == _queen.Position.Y;
    }

    private void MoveCloserToQueen()
    {
        List<Direction> possibleDirections = GetPossibleDirections();
        var randomDirection = possibleDirections[Util.PickRandomNumber(0, possibleDirections.Count)];
        Position = Util.MakeNextMovePosition(randomDirection, Position);
    }

    private void GetKickedToBorder()
    {
        var direction = (Direction)Util.PickRandomNumber(0, 4);
        for (int i = 0; i < _queen.Position.X; i++)
        {
            Position = Util.MakeNextMovePosition(direction, Position);
        }

        /*Position = Util.MakeNextMovePosition(direction, Position);*/
    }

    public override string ToString()
    {
        return "D ";
    }
}