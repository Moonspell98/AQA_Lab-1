using Bogus;
using Person;

namespace Drivers;

public class DataGenerator
{
    public static List<Driver> CreateDrivers(int driversCount)
    {
        var fakeDriver = new Faker<Driver>()
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.DateOfBirth,
                f => f.Date.Past(Driver.DriverMaxAge, DateTime.Now.AddYears(-Driver.DriverMinAge)))
            .RuleFor(p => p.DateOfGetLicense, (f, p) => f.Date.Between(p.DateOfBirth.AddYears(16), DateTime.Now))
            .RuleFor(p => p.LicenseId, f => f.Random.Guid())
            .RuleFor(p => p.Vehicles, f => CreateVehicles(RandomUtils.GetDriverCarsAmount()));
        return fakeDriver.Generate(driversCount);
    }

    public static List<Vehicle> CreateVehicles(int vehiclesCount)
    {
        var fakeVehicle = new Faker<Vehicle>()
            .RuleFor(v => v.Model, f => f.Vehicle.Model())
            .RuleFor(v => v.Year, f => f.Random.Int(Vehicle.MinYear, DateTime.Now.Year))
            .RuleFor(v => v.FuelConsumption, f => f.Random.Int(Vehicle.MinFuelConsumption, Vehicle.MaxFuelConsumption))
            .RuleFor(v => v.IsPricep, f => f.Random.Bool())
            .RuleFor(v => v.SeatsCount, f => f.Random.Int(Vehicle.MinSeatsCount, Vehicle.MaxSeatsCount))
            .RuleFor(v => v.Engine, f => CreateEngine());
        return fakeVehicle.Generate(vehiclesCount);
    }

    public static Engine CreateEngine()
    {
        var fakeEngine = new Faker<Engine>()
            .RuleFor(e => e.Capacity, f => Math.Round(f.Random.Double(Engine.MinCapacity, Engine.MaxCapacity), 1))
            .RuleFor(e => e.Power, f => f.Random.Int(Engine.MinPower, Engine.MaxPower))
            .RuleFor(e => e.MaximumSpeed, f => f.Random.Int(Engine.MinSpeed, Engine.MaxSpeed))
            .RuleFor(e => e.FuelType, f => f.Vehicle.Fuel());
        return fakeEngine.Generate();
    }
}