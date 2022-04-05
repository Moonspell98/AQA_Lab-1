using Person;

namespace Drivers;

public class ChatBot
{
    public static void ShowAllDrivers(List<Driver> drivers)
    {
        Console.WriteLine("| {0, 2} | {1,25} | {2, 15} | {3,20} | {4,37}", "#", "Driver Full Name", "Date of Birth",
            "License issue date", "License ID");
        for (int i = 0; i < drivers.Count; i++)
        {
            Console.WriteLine("| {0, 2} | {1,25} | {2, 15} | {3,20} | {4,37}", i + 1,
                drivers[i].Name + " " + drivers[i].Surname,DateOnly.FromDateTime(drivers[i].DateOfBirth), DateOnly.FromDateTime(drivers[i].DateOfGetLicense), drivers[i].LicenseId);
        }
    }
}