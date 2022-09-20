namespace StudentLib;
public class Student{
    public int Id { get; init; }
    public string GivenName { get; init; }
    public string Surname { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public DateTime GraduationDate { get; init; }
    public Status Status {get {return Findstatus();}}

    public Status Findstatus(){
        Status S = Status.New;
    if(DateTime.Compare(EndDate, DateTime.Now) < 0){ //er EndDate før nu?
                S = Status.Dropout;
            } else if (DateTime.Compare(EndDate, GraduationDate) == 0) { //er end og graduate samme tid?
                S = Status.Graduated;
            } else if (DateTime.Compare(DateTime.Now, GraduationDate) > 0){ //er student aktiv?
                S = Status.Active;
            } else if(DateTime.Compare(DateTime.Now, StartDate) < 0){ //er student ikke startet endnu?
                S = Status.New;
            }
        return S;
    }

    //override ToString() inherited fra 'object'
    public override string ToString() => GivenName + " " + Surname + " " + Id + " " + Status;
}
