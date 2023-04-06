namespace MudServer.Data;

public class Family
{
    public int Id { get; set; }
    public Person Husband { get; set; }
    public Person Wife { get; set; }
    public List<Person> Children { get; set; }
    public DateTime MarriageDate { get; set; }
    public DateTime? DivorceDate { get; set; }

    public Family(int id, Person husband, Person wife, List<Person> children, DateTime marriageDate, DateTime? divorceDate = null)
    {
        Id = id;
        Husband = husband;
        Wife = wife;
        Children = children;
        MarriageDate = marriageDate;
        DivorceDate = divorceDate;
    }
}