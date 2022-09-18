namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Uri_is_secure_test()
    {
        // Arrange 
        Uri uri = new Uri("https://www.awesomewebite.com/");

        // Act
        var awesomeWebite = uri.IsSafe();

        // Assert
        Assert.True(awesomeWebite);
    }

    [Fact]
    public void Uri_is_not_safe()
    {
        // Arrange 
        Uri uri = new Uri("http://www.awesomewebite.com/");

        // Act
        var awesomeWebite = uri.IsSafe();

        // Assert
        Assert.False(awesomeWebite);
    }

    [Fact]
    public void Wordcount_test()
    {
        // Arrange 
        string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

        // Act
        var myString = str.WordCount();

        // Assert
        Assert.Equal(19, myString);
    }
}
