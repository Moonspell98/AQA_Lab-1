using System;

namespace AppointmentBot
{
    public class RandomUtils
    {
        static Random random = new Random();
        public int RandomHours = random.Next(0, 23);
        public int RandomMinutes = random.Next(0, 59);
    }
}