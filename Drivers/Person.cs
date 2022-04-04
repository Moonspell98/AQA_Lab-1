namespace Person;

public class Person
{
    public string Surname { get; set; }
    public string Name { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public DateOnly DateOfGetLicense { get; set; }
    public Guid LicenseId = new Guid();
    public bool IsDriver;
}