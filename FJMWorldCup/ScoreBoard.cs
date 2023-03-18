namespace FJMWorldCup;

public class ScoreBoard
{
    private readonly List<Match> _matchList;
    public List<Match> GetMatchList()
    {
        return _matchList;
    }
    public ScoreBoard()
    {
        _matchList = new List<Match>();
    }

    /// <summary>
    ///  Creates a new match and adds it to the scoreboard
    /// </summary>
    /// <param name="homeTeamName"></param>
    /// <param name="awayTeamName"></param>
    /// <param name="match"></param>
    public void NewGame(Match match)
    {
        _matchList.Add(match);
    }
    /// <summary>
    ///   Updates the score of all matches in the scoreboard
    /// </summary>
    public void UpdateGame()
    {
        foreach (var match in _matchList)
        {
            match.UpdateScore();
        }
    }
    /// <summary>
    /// Returns a list of matches ordered by total goals scored, then by the order they were added to the scoreboard
    /// </summary>
    /// <returns>   </returns>
    public List<Match> GetSummary()
    {
        return _matchList.OrderByDescending(m => m.TotalGoals())
            .ThenByDescending(m=>_matchList.IndexOf(m))
            .ToList();
    }
    /// <summary>
    ///  Clears the scoreboard
    /// </summary>
    public void EndGame()
    {
        _matchList.Clear();
    }
}