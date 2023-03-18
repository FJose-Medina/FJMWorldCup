namespace FJMWorldCup;
using System;
public class Match : IComparable<Match>
{
    private Team _homeTeam;

    public Team HomeTeam
    {
        get => _homeTeam;
    }

    private Team _awayTeam;

    public Team AwayTeam
    {
        get => _awayTeam;
    }
    /// <summary>
    ///  Creates a new match
    /// </summary>
    /// <param name="homeTeamName"></param>
    /// <param name="awayTeamName"></param>
    /// <exception cref="ArgumentException"></exception>
    public Match(string homeTeamName, string awayTeamName)
    {
        if(homeTeamName == awayTeamName) throw new ArgumentException("Home and Away team cannot be the same");
        _homeTeam = new Team(homeTeamName);
        _awayTeam = new Team(awayTeamName);
    }
    /// <summary>
    ///  Updates the score of the match
    /// </summary>
    /// <returns></returns>
    public Match UpdateScore()
    {
        var random = new Random();
        bool homeScored = random.Next(0,HomeTeam.GoalsScored+1 ) == 0;
        bool awayScored = random.Next(0, AwayTeam.GoalsScored+1) == 0;
        
        if(homeScored) HomeTeam.GoalsScored++;
        if(awayScored) AwayTeam.GoalsScored++;
        return this;
    }
    /// <summary>
    ///  Returns the score of the match
    /// </summary>
    public string GetScore()
    {
        return $"{HomeTeam.Name} {HomeTeam.GoalsScored} - {AwayTeam.Name} {AwayTeam.GoalsScored}";
    }
    /// <summary>
    ///  Returns the total goals scored in the match
    /// </summary>
    public int TotalGoals()
    {
        return HomeTeam.GoalsScored + AwayTeam.GoalsScored;
    }
    /// <summary>
    ///  Compares the total goals scored in the match 
    /// </summary>
    /// <param name="other"></param>
    public int CompareTo(Match? other)
    {
        return other == null ? 1 : TotalGoals().CompareTo(other.TotalGoals());
    }
    public static bool operator >  (Match operand1, Match operand2)
    {
        return operand1.CompareTo(operand2) > 0;
    }
    public static bool operator <  (Match operand1, Match operand2)
    {
        return operand1.CompareTo(operand2) < 0;
    }
    public static bool operator >= (Match operand1, Match operand2)
    {
        return operand1.CompareTo(operand2) >= 0;
    }
    public static bool operator <= (Match operand1, Match operand2)
    {
        return operand1.CompareTo(operand2) <= 0;
    }
}