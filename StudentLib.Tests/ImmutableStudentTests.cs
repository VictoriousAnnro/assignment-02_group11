namespace StudentLib.Tests;
using static StudentLib.Status;

public class ImmutableStudentTests
{
    [Fact]
    public void St()
    {
        ImmutableStudent s = new(1, "Mikkel", "Johnsen", new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2011, 5, 1, 8, 30, 52), new DateTime(2014, 5, 1, 8, 30, 52));
        string st = "Mikkel Johnsen 1 Dropout";
        Assert.Equal(st, s.ToString());
    }

    //mangler at lave ordentlige tests
}