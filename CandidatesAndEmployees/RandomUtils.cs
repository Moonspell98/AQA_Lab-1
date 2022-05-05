using System;

namespace CandidatesAndEmployees
{
    public class RandomUtils
    {
        static Random random = new Random();

        public static int MaxPersonsCount()
        {
            return random.Next(1, 100);
        }
    }
}