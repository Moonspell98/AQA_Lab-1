using System.Collections;
using Person;

namespace Drivers;

public class ChatBot
{
    private List<Driver> _drivers;
    private Driver _selectedDriver;
    private Vehicle _selectedVehicle;
    private int SelectedDriverNumber;
    private int SelectedVehicleNumber;

    public ChatBot(List<Driver> drivers)
    {
        _drivers = drivers;
    }

    public void ShowAllDrivers()
    {
        Console.WriteLine("| {0, 2} | {1,25} | {2, 15} | {3,20} | {4,37} | {5,27} |", "#", "Driver Full Name",
            "Date of Birth",
            "License issue date", "License ID", "Driving Experience (Years)");
        foreach (var driver in _drivers)
        {
            int i = 1;
            Console.WriteLine("| {0, 2} | {1,25} | {2, 15} | {3,20} | {4,37} | {5,27} |", i++,
                driver.Name + " " + driver.Surname, DateOnly.FromDateTime(driver.DateOfBirth),
                DateOnly.FromDateTime(driver.DateOfGetLicense), driver.LicenseId,
                driver.GetDrivingExperience());
        }
    }

    public void SelectDriver()
    {
        SelectedDriverNumber =
            NumberChoiceValidator.Validate(1, _drivers.Count, "Please, select driver (enter driver's #):");
        _selectedDriver = _drivers[SelectedDriverNumber - 1];
    }

    public void ShowCars()
    {
        Console.WriteLine(_selectedDriver.Name + " " + _selectedDriver.Surname +
                          "'s cars list:");
        Console.WriteLine("| {0,2} | {1,15} | {2, 10} | {3,30} | {4,15} |", "#", "Model", "Capacity",
            "Fuel Consumption (per 100 km)", "Maximum Speed");
        for (int i = 0; i < _selectedDriver.Vehicles.Count; i++)
        {
            Console.WriteLine("| {0,2} | {1,15} | {2, 10} | {3,30} | {4,15} |",
                i + 1,
                _selectedDriver.Vehicles[i].Model,
                _selectedDriver.Vehicles[i].Engine.Capacity,
                _selectedDriver.Vehicles[i].FuelConsumption,
                _selectedDriver.Vehicles[i].Engine.MaximumSpeed);
        }
    }

    public void SelectCar()
    {
        SelectedVehicleNumber = NumberChoiceValidator.Validate(1, _selectedDriver.Vehicles.Count,
            "Please, select vehicle number(enter vehicle's #)");
        _selectedVehicle = _selectedDriver.Vehicles[SelectedVehicleNumber - 1];
    }

    public void CalculateVehicleAbilities()
    {
        int distance = NumberChoiceValidator.Validate(1, Vehicle.maxDistance,
            "Enter distance to calculate fuel consumption (1-10000 km)");
        Console.WriteLine(
            $"{_selectedVehicle.Model}'s fuel consumption per {distance} km is {_selectedVehicle.FuelConsumptionPerDistance(distance)}");
        distance = NumberChoiceValidator.Validate(1, Vehicle.maxDistance,
            "Specify the distance to calculate the time for which the car will be able to pass it at maximum speed (1-10000 km)");
        Console.WriteLine(
            $"{_selectedVehicle.Model} can pass {distance} km in {_selectedVehicle.TimePerDistance(distance)} hours");
    }
}