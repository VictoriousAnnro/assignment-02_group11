namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void FlattenNumbers_test()
    {
        // Arrange 
        IEnumerable<IEnumerable<int>> xs = new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int>() { 7, 4 } };

        // Act 
        var flattenCount = xs.FlattenNumbers().Count();
        var flattenContains = xs.FlattenNumbers();

        // Assert
        Assert.Equal(5, flattenCount);
        Assert.Contains(1, flattenContains);
        Assert.Contains(2, flattenContains);
        Assert.Contains(3, flattenContains);
        Assert.Contains(7, flattenContains);
        Assert.Contains(4, flattenContains);
    }

    [Fact]
    public void DivisibleNumbers_test()
    {
        // Arrange 
        int[] ys = new int[] { 7, 28, 49, 70, 33, 14, 65 };

        // Act 
        var divisibleNumbers = ys.DivisibleNumbers();

        // Assert
        Assert.Contains(70, divisibleNumbers);
        Assert.Contains(49, divisibleNumbers);
        Assert.DoesNotContain(7, divisibleNumbers);
        Assert.DoesNotContain(65, divisibleNumbers);
        Assert.DoesNotContain(28, divisibleNumbers);
        Assert.DoesNotContain(63, divisibleNumbers);
    }

    [Fact]
    public void LeapYear_test()
    {
        // Arrange 
        int[] ys = new int[] { 2000, 2008, 1700, 1800 };

        // Act 
        var leapYears = ys.IsLeapYear();

        // Assert
        Assert.Contains(2000, leapYears);
        Assert.Contains(2008, leapYears);
        Assert.DoesNotContain(1700, leapYears);
        Assert.DoesNotContain(1800, leapYears);
    }


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
