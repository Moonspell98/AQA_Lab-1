using Bogus;
using Person;

namespace Drivers;

public class DriverGenerator
{
    public static Driver CreateDriver()
    {
        var fakeDriver = new Faker<Driver>()
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.DateOfBirth, f => f.Date.Past(100, DateTime.Now.AddYears(-16)))
            .RuleFor(p => p.DateOfGetLicense, (f, p) => f.Date.Between(p.DateOfBirth.AddYears(16), DateTime.Now))
            .RuleFor(p => p.LicenseId, f => f.Random.Guid());
        return fakeDriver.Generate();
    }
}