namespace StudentLib.Tests;

public class ImmutableStudentTests
{

    [Fact]
    public void Equality_comparer_tester()
    {
        ImmutableStudent s = new(1, "Mikkel", "Johnsen", new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2011, 5, 1, 8, 30, 52), new DateTime(2014, 5, 1, 8, 30, 52), Dropout);
        ImmutableStudent s2 = new(1, "Mikkel", "Johnsen", new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2011, 5, 1, 8, 30, 52), new DateTime(2014, 5, 1, 8, 30, 52), Dropout);
        ImmutableStudent s3 = new(3, "Morten", "Jensen", new DateTime(2009, 5, 1, 8, 30, 52), new DateTime(2012, 5, 1, 8, 30, 52), new DateTime(2012, 5, 1, 8, 30, 52), Graduated);
        Assert.True(s.Equals(s2));
        Assert.False(s.Equals(s3));
    }

    [Fact]
    public void ToString_tester()
    {
        ImmutableStudent s = new(1, "Mikkel", "Johnsen", new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2011, 5, 1, 8, 30, 52), new DateTime(2014, 5, 1, 8, 30, 52), Dropout);
        ImmutableStudent s2 = new(1, "Mikkel", "Johnsen", new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2011, 5, 1, 8, 30, 52), new DateTime(2014, 5, 1, 8, 30, 52), Dropout);
        ImmutableStudent s3 = new(3, "Morten", "Jensen", new DateTime(2009, 5, 1, 8, 30, 52), new DateTime(2012, 5, 1, 8, 30, 52), new DateTime(2012, 5, 1, 8, 30, 52), Graduated);
        Assert.Equal(s.ToString(), s2.ToString());
        Assert.NotEqual(s.ToString(), s3.ToString());
    }
}