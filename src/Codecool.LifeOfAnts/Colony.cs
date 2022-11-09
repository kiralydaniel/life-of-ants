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
    
}