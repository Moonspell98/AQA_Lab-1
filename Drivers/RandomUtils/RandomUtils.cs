using Person;

namespace Drivers;

public class RandomUtils
{
    public static int GetDriverCarsAmount()
    {
        return new Random().Next(Driver.MinCarsAmount, Driver.MaxCarsAmount);
    }
}