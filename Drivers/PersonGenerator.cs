using Bogus;

namespace Person;

public class PersonGenerator
{
    public static Person CreatePerson()
    {
        var fakePerson = new Faker<Person>()
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.DateOfBirth, f => f.Date.Past())
            .RuleFor(p => p.IsDriver, f => f.Random.Bool())
            .RuleFor(p => p.DateOfGetLicense, (f, p) => f.Date.Future(16, p.DateOfBirth))
            .RuleFor(p => p.LicenseId, f => f.Random.Guid());
        return fakePerson.Generate();
    }
}