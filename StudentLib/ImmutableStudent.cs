namespace StudentLib;
using static StudentLib.Status;

public record ImmutableStudent(int Id, string GivenName, string Surname, Status Status, DateTime StartDate, DateTime EndDate, DateTime GraduationDate){
    //public override string ToString() => GivenName + " " + Surname + " " + Id; 
    //hvad med status? skal den være parameter? eller skal den sættes ligesom i Student.cs??
    //svært at bedømme ud fra opg.beskrivelsen
    //skal vi overhovedet lave en tostring for den her??? fucking opgave er mega vague
}