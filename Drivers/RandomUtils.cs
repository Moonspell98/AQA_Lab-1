using Person;

namespace Drivers;

public class RandomUtils
{
    public static int GetDriverCarsAmount()
    {
        Random random = new Random();
        return random.Next(Driver.MinCarsAmount, Driver.MaxCarsAmount);
    }
}