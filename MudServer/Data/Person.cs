namespace MudServer.Data;

public class Person
{
    public int Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Gender { get; }
    public DateTime BirthDate { get; }
    public DateTime? DeathDate { get; }
    public List<Family> Families { get; }

    public Person(int id, string firstName, string lastName, string gender, DateTime birthDate, DateTime? deathDate)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        BirthDate = birthDate;
        DeathDate = deathDate;
        Families = new List<Family>();
    }
}
