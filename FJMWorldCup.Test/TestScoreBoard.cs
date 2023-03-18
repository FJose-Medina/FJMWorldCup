namespace FJMWorldCup.Test;

public class TestScoreBoard
{
    [Fact]
    public void TestConstructor()
    {
        // Arrange
        var scoreBoard = new ScoreBoard();
        // Act
        
        // Assert
        Assert.NotNull(scoreBoard);
    }
    [Fact]
    public void TestAddMatch()
    {
        // Arrange
        var scoreBoard = new ScoreBoard();
        var match = new Match("Home", "Away");
        // Act
        scoreBoard.NewGame(match);
        // Assert
        Assert.Single(scoreBoard.GetMatchList());
    }
    [Fact]
    public void TestUpdateGame()
    {
        // Arrange
        var scoreBoard = new ScoreBoard();
        var match = new Match("Home", "Away");
        scoreBoard.NewGame(match);
        // Act
        scoreBoard.UpdateGame();
        // Assert
        Assert.True(match.HomeTeam.GoalsScored >= 0);
        Assert.True(match.AwayTeam.GoalsScored >= 0);
    }
    [Fact]
    public void TestGetMatchList()
    {
        // Arrange
        var scoreBoard = new ScoreBoard();
        var match = new Match("Home", "Away");
        scoreBoard.NewGame(match);
        // Act
        var matchList = scoreBoard.GetMatchList();
        // Assert
        Assert.Single(matchList);
    }
    [Fact]
    public void TestGetMatchListEmpty()
    {
        // Arrange
        var scoreBoard = new ScoreBoard();
        // Act
        var matchList = scoreBoard.GetMatchList();
        // Assert
        Assert.Empty(matchList);
    }
    [Fact]
    public void TestGetSummary()
    {
        // Arrange
        var scoreBoard = new ScoreBoard();
        var match = new Match("Home", "Away");
        scoreBoard.NewGame(match);
        // Act
        var summary = scoreBoard.GetSummary();
        // Assert
        Assert.NotNull(summary);
    }
    [Fact]
    public void TestGetSummaryEmpty()
    {
        // Arrange
        var scoreBoard = new ScoreBoard();
        // Act
        var summary = scoreBoard.GetSummary();
        // Assert
        Assert.Empty(summary);
    }
    [Fact]
    public void TestGetSummaryMultipleMatches()
    {
        // Arrange
        var scoreBoard = new ScoreBoard();
        var match1 = new Match("HomeMatch1", "AwayMatch1");
        var match2 = new Match("HomeMatch2", "AwayMatch2");
        scoreBoard.NewGame(match1);
        scoreBoard.NewGame(match2);
        // Act
        var summary = scoreBoard.GetSummary();
        // Assert
        Assert.NotEqual(scoreBoard.GetMatchList()[0].HomeTeam.Name, summary[0].HomeTeam.Name);
    }
    
}