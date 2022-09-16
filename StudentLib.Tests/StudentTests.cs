namespace StudentLib.Tests;

public class StudentTests
{
    [Fact]
    public void Student_ToString_should_return_name_id_and_statusDropout()
    {
        Student s = new Student(1, "Mikkel", "Johnsen", new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2011, 5, 1, 8, 30, 52), new DateTime(2014, 5, 1, 8, 30, 52));
        string st = "Mikkel Johnsen 1 Dropout";

        Assert.Equal(st, s.ToString());
    }
}