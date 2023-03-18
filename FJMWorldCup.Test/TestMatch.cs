namespace FJMWorldCup.Test;

public class TestMatch
{
    public void TestConstructor()
    {
        // Arrange
        string expectedHomeTeamName = "Home";
        string expectedAwayTeamName = "Away";
        int expectedHomeTeamGoals = 0;
        int expectedAwayTeamGoals = 0;
        
        // Act
        var match = new Match(expectedHomeTeamName, expectedAwayTeamName);
        
        // Assert
        Assert.Equal(expectedHomeTeamName, match.HomeTeam.Name);
        Assert.Equal(expectedAwayTeamName, match.AwayTeam.Name);
        Assert.Equal(expectedHomeTeamGoals, match.HomeTeam.GoalsScored);
        Assert.Equal(expectedAwayTeamGoals, match.AwayTeam.GoalsScored);
    }
    [Fact]
    public void TestUpdateScore()
    {
        // Arrange
        var match = new Match("Home", "Away");

        
        // Act
        match.UpdateScore();
        
        // Assert
        Assert.True(match.HomeTeam.GoalsScored >= 0);
        Assert.True(match.AwayTeam.GoalsScored >= 0);
    }
    [Fact]
    public void TestGetScore()
    {
        // Arrange
        var match = new Match("Home", "Away");
        match.HomeTeam.GoalsScored = 1;
        match.AwayTeam.GoalsScored = 2;
        string expectedScore = "Home 1 - Away 2";
        
        // Act
        var actualScore = match.GetScore();
        
        // Assert
        Assert.Equal(expectedScore, actualScore);
    }
    [Fact]
    public void TestTotalGoals()
    {
        // Arrange
        var match = new Match("Home", "Away");
        match.HomeTeam.GoalsScored = 1;
        match.AwayTeam.GoalsScored = 2;
        int expectedTotalGoals = 3;
        
        // Act
        var actualTotalGoals = match.TotalGoals();
        
        // Assert
        Assert.Equal(expectedTotalGoals, actualTotalGoals);
    }
    [Fact]
    public void TestCompareTo()
    {
        // Arrange
        var match1 = new Match("Home", "Away");
        match1.HomeTeam.GoalsScored = 1;
        match1.AwayTeam.GoalsScored = 2;
        var match2 = new Match("Home", "Away");
        match2.HomeTeam.GoalsScored = 2;
        match2.AwayTeam.GoalsScored = 1;
        int expectedCompareTo = -1;
        
        // Act
        var actualCompareTo = match1.CompareTo(match2);
        
        // Assert
        Assert.Equal(expectedCompareTo, actualCompareTo);
    }
}