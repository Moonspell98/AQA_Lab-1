using System;
using System.Collections.Generic;
using Bogus;

namespace CandidatesAndEmployees
{
    public static class RandomPersonsGenerator
    {
        public static List<Candidate> GenerateCandidates()
        {
            var candidate = new Candidate();
            var candidates = new List<Candidate>();
            for (int i = 0; i < RandomUtils.MaxPersonsCount(); i++)
            {
                candidates.Add((Candidate)UserFactory.GenerateUser(candidate));
            }
            return candidates;
        }

        public static List<Employee> GenerateEmployees()
        {
            var employee = new Employee();
            var employees = new List<Employee>();
            for (int i = 0; i < RandomUtils.MaxPersonsCount(); i++)
            {
                employees.Add((Employee)UserFactory.GenerateUser(employee));
            }
            return employees;
        }
    }
}