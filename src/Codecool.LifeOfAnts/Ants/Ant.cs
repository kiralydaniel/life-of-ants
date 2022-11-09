namespace Codecool.LifeOfAnts.Ants;

public abstract class Ant
{
    private Position _position;

    public Position Position
    {
        get => _position;
        set => _position = value;
    }

    protected Ant(Position position)
    {
        _position = position;
    }

    public abstract override string ToString();
}