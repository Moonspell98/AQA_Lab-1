using Drivers;

namespace Person;

public class Driver : Person
{
    public static int DriverMaxAge = 100;
    public static int DriverMinAge = 16;
    public static int MaxCarsAmount = 3;
    public static int MinCarsAmount = 1;
    public List<Vehicle> Vehicles { get; set; }
    public DateTime DateOfGetLicense { get; set; }
    public Guid LicenseId { get; set; }

    public int GetDrivingExperience()
    {
        return Convert.ToInt16(DateTime.Now.Subtract(DateOfGetLicense).Days / 365.2425);
    }
}