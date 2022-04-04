using System;

namespace CandidatesAndEmployees
{
    public class RandomUtils
    {
        public static int MaxPersonsCount()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}