namespace FJMWorldCup;

public class Team
{
    private string _name;
    private int _goalsScored;

    public Team(string name)
    {
        if(string.IsNullOrEmpty(name)) throw new ArgumentException("Team name cannot be null or empty");
        _name = name;
        _goalsScored = 0;
    }

    public string Name
    {
        get { return _name; }
    }

    public int GoalsScored
    {
        get { return _goalsScored; }
        set => _goalsScored = value;
    }
}