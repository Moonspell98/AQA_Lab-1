using System;

namespace CandidatesAndEmployees
{
    public class Candidate : IPerson, IComparable
    {
        public string DesiredPosition { get; set; }
        public int DesiredSalary { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PositionDescription { get; set; }
        public Guid id = new Guid();
        
        public void PrintInfo()
        {
            Console.WriteLine($"Hello, I am {Name} {Surname} I want to be a {DesiredPosition} ({PositionDescription}) with a salary from {DesiredSalary}");
        }

        public int CompareTo(object? obj)
        {
            if (obj is Candidate candidate)
            {
                return DesiredPosition.CompareTo(candidate.Name);
            }
            else
            {
                throw new Exception("Incorrect parameter value");
            }
            
        }
    }
}