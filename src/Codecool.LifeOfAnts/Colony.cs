using System;
using System.Collections.Generic;
using Codecool.LifeOfAnts.Ants;

namespace Codecool.LifeOfAnts;

public class Colony
{
    private List<Ant> _ants = new List<Ant>();
    private int _colonyWidth;

    public Colony(int colonyWidth)
    {
        _colonyWidth = colonyWidth;
    }

    private Position FindCenter()
    {
        int centerCoord = (_colonyWidth - 1) / 2;
        return new Position(centerCoord, centerCoord);
    }

    public void Update()
    {
        foreach (Ant ant in _ants)
        {
            ant.Act(_colonyWidth);
        }
    }

    public void Display()
    {
        Console.WriteLine(BoardBuilder.BuildBoard(_colonyWidth, _ants));
    }

    public void GenerateAntColony(int drones, int workers, int soldiers)
    {
        Position center = FindCenter();
        Ant queen = new AntQueen(center);
        _ants.Add(queen);
        for (int i = 0; i < drones; i++)
        {
            _ants.Add(new AntDrone(Util.GetStartPosition(_colonyWidth), (AntQueen)queen));
        }

        for (int i = 0; i < workers; i++)
        {
            _ants.Add(new AntWorker(Util.GetStartPosition(_colonyWidth)));
        }

        for (int i = 0; i < soldiers; i++)
        {
            _ants.Add(new AntSoldier(Util.GetStartPosition(_colonyWidth)));
        }
    }
}