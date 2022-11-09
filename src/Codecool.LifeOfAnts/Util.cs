using System;

namespace Codecool.LifeOfAnts;

public static class Util
{
    public static Position GetStartPosition(int width)
    {
        Position position = new Position(PickRandomNumber(0, width), PickRandomNumber(0, width));
        return position;
    }

    public static int PickRandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    public static bool IsPositionValid(Position position, int width)
    {
        return position.X < width && position.Y < width && position.X >= 0 && position.Y >= 0;
    }
    public static Position MakeNextMovePosition(Direction direction, Position currentPosition)
    {
        Position newPosition = currentPosition;
        switch (direction)
        {
            case Direction.North:
                newPosition = new Position(currentPosition.X - 1, currentPosition.Y);
                break;
            case Direction.South:
                newPosition = new Position(currentPosition.X + 1, currentPosition.Y);
                break;
            case Direction.East:
                newPosition = new Position(currentPosition.X, currentPosition.Y + 1);
                break;
            case Direction.West:
                newPosition = new Position(currentPosition.X, currentPosition.Y - 1);
                break;
        }

        return newPosition;
    }
}