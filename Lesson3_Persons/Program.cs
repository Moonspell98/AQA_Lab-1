using System;

namespace Lesson3_Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Belarus", "Minsk", "Tolstogo 10", "TechArt");
            Candidate tom = new Candidate("Tom", "Jackson", "Junior QA", "QA without experience", 500);
            Employee vitaly = new Employee("Vitaly", "Petrov", "Senior QA", "QA with 5 years of experience", 3000, company);
            tom.PrintInfo();
            vitaly.PrintInfo();

            
        }
    }
}