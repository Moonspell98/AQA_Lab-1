using Bogus.DataSets;

namespace Person;

public class Person
{
    public string Surname { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public bool IsDriver
    { 
        get
             {
                 return IsDriver;
             }
        set
        {
            if ((DateTime.Now - DateOfBirth).Days >= 5840)
            {
                IsDriver = value;
            }
            else
            {
                IsDriver = false;
            }
        }
    }

    public DateTime? DateOfGetLicense
    {
        get { return DateOfGetLicense; }
        set
        {
            if (IsDriver)
            {
                DateOfGetLicense = value;
            }
            else
            {
                DateOfGetLicense = null;
            }
        }
    }
    public Guid LicenseId = new Guid();

}