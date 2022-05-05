using System;
using System.Collections;

namespace CandidatesAndEmployees
{
    public class Employee : IPerson, IComparable
    {
        public static int minSalary = 500;
        public static int maxSalary = 5000;

        public Company Company { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PositionDescription { get; set; }
        public Guid Id { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine(
                $"Hello, I am {Name} {Surname}, {Position} in {Company.Name} ({Company.Country}, {Company.City}, {Company.Address}) and my salary {Salary}");
        }

        public int CompareTo(object? obj)
        {
            if (obj is Employee employee)
            {
                return Company.Name.CompareTo(employee.Company.Name);
            }
            else
            {
                throw new Exception("Incorrect parameter value");
            }
        }
    }
}