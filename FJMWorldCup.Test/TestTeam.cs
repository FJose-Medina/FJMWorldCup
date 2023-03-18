using System.Reflection;

namespace FJMWorldCup.Test;

public class TestTeam
{
    [Fact]
    public void TestConstructor()
    {
        // Arrange
        string expectedName = "Team";
        int expectedGoalsScored = 0;
        
        // Act
        var team = new Team(expectedName);
        
        // Assert
        Assert.Equal("Team", team.Name);
        Assert.Equal(expectedGoalsScored, team.GoalsScored);
    }
    [Fact]
    public void TestGoals()
    {
        // Arrange
        int expectedGoals= 3;
        Team team = new Team("Team");

        // Act
        team.GoalsScored = expectedGoals;

        // Assert
        Assert.Equal(expectedGoals, team.GoalsScored);
    }
    [Fact] 
    public void TestNameEmpty()
    {
        // Arrange
        string expectedName = "";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Team(expectedName));
    }
    [Fact]
    public void TestNameNull()
    {
        // Arrange
        string expectedName = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Team(expectedName));
    }
}