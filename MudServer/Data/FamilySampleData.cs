namespace MudServer.Data;

public class FamilySampleData
{
    private static int _id = 1;

    private static Person CreatePerson(string firstName, string lastName, string gender, DateTime birthDate,
        DateTime? deathDate)
    {
        return new Person(_id++, firstName, lastName, gender, birthDate, deathDate);
    }

    private static Family CreateFamily(Person husband, Person wife, List<Person> children, DateTime marriageDate,
        DateTime? divorceDate = null)
    {
        return new Family(_id++, husband, wife, children, marriageDate, divorceDate);
    }

    public static List<Family> Generate()
    {
        var families = new List<Family>();

        // 1st Generation
        var john = CreatePerson("John", "Doe", "M", new DateTime(1950, 1, 1), new DateTime(2010, 1, 1));
        var jane = CreatePerson("Jane", "Doe", "F", new DateTime(1955, 1, 1), new DateTime(2015, 1, 1));
        families.Add(CreateFamily(john, jane, new List<Person>(), new DateTime(1975, 1, 1)));

        // 2nd Generation
        var jenny = CreatePerson("Jenny", "Doe", "F", new DateTime(1980, 1, 1), null);
        var jeff = CreatePerson("Jeff", "Doe", "M", new DateTime(1982, 1, 1), null);
        var jack = CreatePerson("Jack", "Doe", "M", new DateTime(1984, 1, 1), null);
        var jill = CreatePerson("Jill", "Doe", "F", new DateTime(1986, 1, 1), null);
        var jesse = CreatePerson("Jesse", "Doe", "M", new DateTime(1988, 1, 1), null);
        var jared = CreatePerson("Jared", "Doe", "M", new DateTime(1990, 1, 1), null);
        families.Add(CreateFamily(jeff, jenny, new List<Person> { jack, jill }, new DateTime(2009, 1, 1)));
        families.Add(CreateFamily(jesse, jenny, new List<Person> { jared }, new DateTime(2015, 1, 1)));

        // 3rd Generation
        var jacob = CreatePerson("Jacob", "Doe", "M", new DateTime(2011, 1, 1), null);
        var jocelyn = CreatePerson("Jocelyn", "Doe", "F", new DateTime(2013, 1, 1), null);
        var jenna = CreatePerson("Jenna", "Doe", "F", new DateTime(2016, 1, 1), null);
        var julian = CreatePerson("Julian", "Doe", "M", new DateTime(2019, 1, 1), null);
        families.Add(CreateFamily(jack, CreatePerson("Julia", "Doe", "F", new DateTime(1989, 1, 1), null), new List<Person> { jacob, jocelyn, jenna, julian }, new DateTime(2012, 1, 1)));

        // 4th Generation
        var jackson = CreatePerson("Jackson", "Doe", "M", new DateTime(2020, 1, 1), null);
        var jennaSpouse = CreatePerson("Michael", "Smith", "M", new DateTime(2015, 1, 1), null);
        families.Add(CreateFamily(jenna, jennaSpouse, new List<Person> { jackson }, new DateTime(2020, 1, 1)));

        // 5th Generation
        var lucas = CreatePerson("Lucas", "Doe", "M", new DateTime(2015, 1, 1), null);
        var liamSpouse = CreatePerson("Emily", "Johnson", "F", new DateTime(2015, 1, 1), null);
        var liam = CreatePerson("Liam", "Doe", "M", new DateTime(2020, 1, 1), null);
        families.Add(CreateFamily(lucas, liamSpouse, new List<Person> { liam }, new DateTime(2020, 1, 1)));

        // 6th Generation
        var oliver = CreatePerson("Oliver", "Doe", "M", new DateTime(2022, 1, 1), null);
        var oliverSpouse = CreatePerson("Ava", "Brown", "F", new DateTime(2023, 1, 1), null);
        var sophia = CreatePerson("Sophia", "Doe", "F", new DateTime(2025, 1, 1), null);
        families.Add(CreateFamily(oliver, oliverSpouse, new List<Person> { sophia }, new DateTime(2024, 1, 1)));

        return families;
    }

}
