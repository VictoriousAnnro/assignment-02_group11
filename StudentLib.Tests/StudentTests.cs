namespace StudentLib.Tests;

public class StudentTests
{
    [Fact]
    public void Student_ToString_should_return_name_id_and_statusDropout()
    {
        var student = new Student{
            Id = 1,
            GivenName = "Mikkel",
            Surname = "Johnsen",
            StartDate =new DateTime(2008, 5, 1, 8, 30, 52),
            EndDate = new DateTime(2011, 5, 1, 8, 30, 52),
            GraduationDate = new DateTime(2014, 5, 1, 8, 30, 52),
        };
        //Student(1, "Mikkel", "Johnsen", new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2011, 5, 1, 8, 30, 52), new DateTime(2014, 5, 1, 8, 30, 52));
        string st = "Mikkel Johnsen 1 Dropout";

        Assert.Equal(st, student.ToString());
    }
}