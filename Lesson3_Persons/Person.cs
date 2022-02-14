using System;
using System.Dynamic;
using System.Threading;

namespace Lesson3_Persons
{
    
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PositionDescription { get; set; }

        public Guid id = new Guid();

        public Person(string name, string surname, string positionDescription)
        {
            Name = name;
            Surname = surname;
            PositionDescription = positionDescription;
            id = Guid.NewGuid();
        }
        
    }
    public class Candidate : Person, IPrintable
    {
        public string DesiredPosition { get; set; }
        public int DesiredSalary { get; set; }
        public Candidate(string name,string surname, string positionDescription ,string desiredPosition, int desiredSalary)
            : base(name, surname, positionDescription)
        {
            DesiredPosition = desiredPosition;
            DesiredSalary = desiredSalary;
            id = Guid.NewGuid();
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Hello, I am {Name} {Surname} I want to be a {DesiredPosition} ({PositionDescription}) with a salary from {DesiredSalary}");
        }
    }
    

    public class Employee : Person, IPrintable
    {
        public Company Company { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public Employee(string name, string surname, string position, string positionDescription, int salary, Company company)
            : base(name, surname, positionDescription)
        {
           Company = company;
           Position = position;
           Salary = salary;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Hello, I am {Name} {Surname}, {Position} in {Company.Name} ({Company.Country}, {Company.City}, {Company.Address}) and my salary {Salary}");
        }
    }
}