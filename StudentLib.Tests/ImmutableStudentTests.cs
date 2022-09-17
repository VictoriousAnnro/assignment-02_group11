namespace StudentLib.Tests;
using static StudentLib.Status;

public class ImmutableStudentTests
{

    [Fact]
    public void Equality_comparer_tester()
    {
        ImmutableStudent s = new(1, "Mikkel", "Johnsen", Dropout, new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2011, 5, 1, 8, 30, 52), new DateTime(2014, 5, 1, 8, 30, 52));
        ImmutableStudent s2 = new(1, "Mikkel", "Johnsen", Dropout, new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2011, 5, 1, 8, 30, 52), new DateTime(2014, 5, 1, 8, 30, 52));
        ImmutableStudent s3 = new(3, "Morten", "Jensen", Graduated, new DateTime(2009, 5, 1, 8, 30, 52), new DateTime(2012, 5, 1, 8, 30, 52), new DateTime(2012, 5, 1, 8, 30, 52));
        Assert.Equal(s, s2);
        Assert.NotEqual(s, s3);
    }

    //mangler at lave ordentlige tests
}