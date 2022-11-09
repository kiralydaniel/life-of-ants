using System;
using System.Collections.Generic;
using System.Text;
using Codecool.LifeOfAnts.Ants;

namespace Codecool.LifeOfAnts;

static class BoardBuilder
{
    public static string BuildBoard(int width, List<Ant> ants)
    {
        StringBuilder board = new StringBuilder();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                board.Append(GetFieldString((i, j), ants));
            }

            board.Append(Environment.NewLine);
        }

        return board.ToString();
    }

    private static string GetFieldString((int, int) field, List<Ant> ants)
    {
        foreach (Ant ant in ants)
        {
            if (ant.Position.X == field.Item1 && ant.Position.Y == field.Item2)
            {
                return ant.ToString();
            }
        }

        return ". ";
    }
}