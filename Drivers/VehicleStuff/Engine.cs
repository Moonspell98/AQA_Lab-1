namespace Drivers;

public class Engine
{
    public static double minCapacity = 1;
    public static double maxCapacity = 5.3;
    public static int minPower = 80;
    public static int maxPower = 400;
    public static int minSpeed = 120;
    public static int maxSpeed = 350;
    public int Power { get; set; }
    public double Capacity { get; set; }
    public int MaximumSpeed { get; set; }
    public string FuelType { get; set; }
}