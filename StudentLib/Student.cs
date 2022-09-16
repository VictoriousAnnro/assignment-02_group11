namespace StudentLib;

using static StudentLib.Status;

public class Student{
    public int Id { get; init; }
    string GivenName, Surname;
    public Status Status { get; }
    DateTime StartDate, EndDate, GraduationDate;

    public Student(int Id, string GivenName, string Surname, 
    DateTime StartDate, DateTime EndDate, DateTime GraduationDate){
        this.Id = Id;
        this.GivenName = GivenName;
        this.Surname = Surname;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.GraduationDate = GraduationDate;

        if(DateTime.Compare(EndDate, DateTime.Now) < 0){ //er EndDate før nu?
            this.Status = Status.Dropout;
        } else if (DateTime.Compare(EndDate, GraduationDate) == 0) { //er end og graduate samme tid?
            this.Status = Status.Graduated;
        } else if (DateTime.Compare(DateTime.Now, GraduationDate) > 0){ //er student aktiv?
            this.Status = Status.Active;
        } //hb new? wtf does that mean??


    }

    //override ToString() inherited fra 'object'
    public override string ToString() => GivenName + " " + Surname + " " + Id + " " + Status;
}
