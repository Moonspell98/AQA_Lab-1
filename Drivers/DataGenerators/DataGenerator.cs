using Bogus;
using Person;

namespace Drivers;

public class DataGenerator
{
    public static Driver CreateDriver()
    {
        var fakeDriver = new Faker<Driver>()
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.DateOfBirth,
                f => f.Date.Past(Driver.DriverMaxAge, DateTime.Now.AddYears(-Driver.DriverMinAge)))
            .RuleFor(p => p.DateOfGetLicense, (f, p) => f.Date.Between(p.DateOfBirth.AddYears(16), DateTime.Now))
            .RuleFor(p => p.LicenseId, f => f.Random.Guid());
        Driver driver = fakeDriver.Generate();
        driver.Vehicles = CreateVehicles(RandomUtils.GetDriverCarsAmount());
        return driver;
    }

    public static Vehicle CreateVehicle()
    {
        var fakeVehicle = new Faker<Vehicle>()
            .RuleFor(v => v.Model, f => f.Vehicle.Model())
            .RuleFor(v => v.Year, f => f.Random.Int(Vehicle.minYear, DateTime.Now.Year))
            .RuleFor(v => v.FuelConsumption, f => f.Random.Int(Vehicle.minFuelConsumption, Vehicle.maxFuelConsumption))
            .RuleFor(v => v.IsPricep, f => f.Random.Bool())
            .RuleFor(v => v.SeatsCount, f => f.Random.Int(Vehicle.minSeatsCount, Vehicle.maxSeatsCount));
        Vehicle vehicle = fakeVehicle.Generate();
        vehicle.Engine = CreateEngine();
        return vehicle;
    }

    public static List<Vehicle> CreateVehicles(int vehiclesAmount)
    {
        var vehicles = new List<Vehicle>();
        for (int i = 0; i < vehiclesAmount; i++)
        {
            vehicles.Add(CreateVehicle());
        }

        return vehicles;
    }

    public static Engine CreateEngine()
    {
        var fakeEngine = new Faker<Engine>()
            .RuleFor(e => e.Capacity, f => Math.Round(f.Random.Double(Engine.minCapacity, Engine.maxCapacity), 1))
            .RuleFor(e => e.Power, f => f.Random.Int(Engine.minPower, Engine.maxPower))
            .RuleFor(e => e.MaximumSpeed, f => f.Random.Int(Engine.minSpeed, Engine.maxSpeed))
            .RuleFor(e => e.FuelType, f => f.Vehicle.Fuel());
        return fakeEngine.Generate();
    }
}