namespace Codecool.LifeOfAnts.Ants;

public class AntQueen : Ant
{
    private int _matingMoodCounter;
    private bool _isReadyToMate;

    public int MatingMoodCounter
    {
        get => _matingMoodCounter;
        set => _matingMoodCounter = value;
    }

    public bool IsReadyToMate
    {
        get => _isReadyToMate;
        set => _isReadyToMate = value;
    }

    public AntQueen(Position position) : base(position)
    {
        _matingMoodCounter = Util.PickRandomNumber(50, 100);
        _isReadyToMate = false;
    }

    public override void Act(int width)
    {
        if (_matingMoodCounter == 0)
        {
            _isReadyToMate = true;
        }
        else
        {
            _matingMoodCounter--;
        }
    }

    public override string ToString()
    {
        return "Q ";
    }
}