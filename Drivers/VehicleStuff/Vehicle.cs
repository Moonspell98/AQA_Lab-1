using Person;

namespace Drivers;

public class Vehicle
{
    public static int maxSeatsCount = 8;
    public static int minSeatsCount = 2;
    public static int minYear = 1980;
    public static int maxFuelConsumption = 20;
    public static int minFuelConsumption = 3;
    public string Model { get; set; }
    public int Year { get; set; }
    public Driver Owner { get; set; }
    public Engine Engine { get; set; }
    public bool IsPricep { get; set; }
    public int SeatsCount { get; set; }
    public int FuelConsumption { get; set; }

    public double FuelConsumptionPerDistance(int distance)
    {
        return distance * ((double)FuelConsumption / 100);
    }

    public double TimePerDistance(int distance)
    {
        return (double)distance / Engine.MaximumSpeed;
    }
}