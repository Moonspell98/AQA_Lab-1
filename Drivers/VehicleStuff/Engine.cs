namespace Drivers;

public class Engine
{
    public static double MinCapacity = 1;
    public static double MaxCapacity = 5.3;
    
    public static int MinPower = 80;
    public static int MaxPower = 400;
    
    public static int MinSpeed = 120;
    public static int MaxSpeed = 350;
    
    public int Power { get; set; }
    public double Capacity { get; set; }
    public int MaximumSpeed { get; set; }
    public string FuelType { get; set; }
}