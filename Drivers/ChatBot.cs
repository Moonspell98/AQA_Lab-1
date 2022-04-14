using System.Collections;
using Person;

namespace Drivers;

public class ChatBot
{
    public static int SelectedDriverNumber;
    private static int SelectedDriverIndex;
    public static int NumberOfDrivers;
    public static int SelectedVehicleNumber;
    public static int SelectedVehicleIndex;

    public static void ShowAllDrivers(List<Driver> drivers)
    {
        NumberOfDrivers = drivers.Count;
        Console.WriteLine("| {0, 2} | {1,25} | {2, 15} | {3,20} | {4,37} | {5,5} |", "#", "Driver Full Name",
            "Date of Birth",
            "License issue date", "License ID", "Driving Experience (Years)");
        for (int i = 0; i < NumberOfDrivers; i++)
        {
            Console.WriteLine("| {0, 2} | {1,25} | {2, 15} | {3,20} | {4,37} | {5,5} |", i + 1,
                drivers[i].Name + " " + drivers[i].Surname, DateOnly.FromDateTime(drivers[i].DateOfBirth),
                DateOnly.FromDateTime(drivers[i].DateOfGetLicense), drivers[i].LicenseId,
                drivers[i].GetDrivingExperience());
        }
    }

    public static void SelectDriver()
    {
        SelectedDriverNumber =
            NumberChoiceValidator.Validate(1, NumberOfDrivers, "Please, select driver (enter driver's #):");
        SelectedDriverIndex = SelectedDriverNumber - 1;
    }

    public static void ShowInfo(List<Driver> drivers)
    {
        Console.WriteLine(drivers[SelectedDriverIndex].Name + " " + drivers[SelectedDriverIndex].Surname +
                          "'s cars list:");
        Console.WriteLine("| {0,2} | {1,15} | {2, 10} | {3,30} | {4,15} |", "#", "Model", "Capacity",
            "Fuel Consumption (per 100 km)", "Maximum Speed");
        for (int i = 0; i < drivers[SelectedDriverIndex].Vehicles.Count; i++)
        {
            Console.WriteLine("| {0,2} | {1,15} | {2, 10} | {3,30} | {4,15} |",
                i + 1,
                drivers[SelectedDriverIndex].Vehicles[i].Model,
                drivers[SelectedDriverIndex].Vehicles[i].Engine.Capacity,
                drivers[SelectedDriverIndex].Vehicles[i].FuelConsumption,
                drivers[SelectedDriverIndex].Vehicles[i].Engine.MaximumSpeed);
        }

        SelectedVehicleNumber = NumberChoiceValidator.Validate(1, drivers[SelectedDriverIndex].Vehicles.Count,
            "Please, select vehicle number(enter vehicle's #)");
        SelectedVehicleIndex = SelectedVehicleNumber - 1;
        int distance = NumberChoiceValidator.Validate(1, 10000, "Enter distance to calculate fuel consumption (1-10000 km)");
        Console.WriteLine(drivers[SelectedDriverIndex].Vehicles[SelectedVehicleIndex].Model +
                          "'s fuel consumption per " + distance + " km" + " is " +
                          drivers[SelectedDriverIndex].Vehicles[SelectedVehicleIndex]
                              .FuelConsumptionPerDistance(distance));
        distance = NumberChoiceValidator.Validate(1, 10000, "Specify the distance to calculate the time for which the car will be able to pass it at maximum speed (1-10000 km)");
        Console.WriteLine(drivers[SelectedDriverIndex].Vehicles[SelectedVehicleIndex].Model +
                          " can pass " + distance + " km" + " in " +
                          drivers[SelectedDriverIndex].Vehicles[SelectedVehicleIndex]
                              .TimePerDistance(distance) + " hours");
    }
}