namespace StudentLib;

public record ImmutableStudent(int Id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate, Status Status){

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
}