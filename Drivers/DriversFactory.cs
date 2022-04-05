using Person;

namespace Drivers;

public class DriversFactory
{
    public static List<Driver> GenerateDrivers(int driversCount)
    {
        var drivers = new List<Driver>();
        for (int i = 0; i < driversCount; i++)
        {
            drivers.Add(DriverGenerator.CreateDriver());
        }
        return drivers;
    }
}