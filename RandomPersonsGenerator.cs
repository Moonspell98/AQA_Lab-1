using System;
using System.Collections.Generic;
using Bogus;

namespace CandidatesAndEmployees
{
    public static class RandomPersonsGenerator
    {
        public static List<Candidate> GenerateCandidates()
        {
            Random random = new Random();
            var maxValue = random.Next(1, 100);
            var candidate = new Candidate();
            var candidates = new List<Candidate>();
            for (int i = 0; i < 100; i++)
            {
                candidates.Add((Candidate)UserFactory.GenerateUser(candidate));
            }
            return candidates;
        }

        public static List<Employee> GenerateEmployees()
        {
            Random random = new Random();
            var maxValue = random.Next(1, 100);
            var employee = new Employee();
            var employees = new List<Employee>();
            for (int i = 0; i < maxValue; i++)
            {
                employees.Add((Employee)UserFactory.GenerateUser(employee));
            }
            return employees;
        }
    }
}