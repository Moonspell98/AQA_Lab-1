using Bogus;

namespace CandidatesAndEmployees
{
    public static class UserFactory
    {
        public static IPerson GenerateUser(IPerson person)
        {
            IPerson generatedPerson = null;
            if (person is Candidate)
            {
                generatedPerson = CreateCandidate();
            }
            if (person is Employee)
            {
                generatedPerson = CreateEmployee();
            }
            return generatedPerson;
        }

        private static Candidate CreateCandidate()
        {
            var fakeCandidate = new Faker<Candidate>()
                .RuleFor(cn => cn.DesiredPosition, f => f.Name.JobTitle())
                .RuleFor(cn => cn.PositionDescription, f => f.Name.JobDescriptor())
                .RuleFor(cn => cn.Name, f => f.Person.FirstName)
                .RuleFor(cn => cn.Surname, f => f.Person.LastName)
                .RuleFor(cn => cn.DesiredSalary, f => f.Person.Random.Int(500, 4000))
                .RuleFor(cn => cn.id, f => f.Random.Guid());
            return fakeCandidate.Generate();
        }

        private static Employee CreateEmployee()
        {
            var fakeEmployee = new Faker<Employee>()
                .RuleFor(em => em.Name, f => f.Person.FirstName)
                .RuleFor(em => em.Surname, f => f.Person.LastName)
                .RuleFor(em => em.Position, f => f.Name.JobTitle())
                .RuleFor(em => em.PositionDescription, f => f.Name.JobDescriptor())
                .RuleFor(em => em.id, f => f.Random.Guid())
                .RuleFor(em => em.Salary, f => f.Random.Int(500, 5000))
                .RuleFor(em => em.Company, f => CreateCompany());
            return fakeEmployee.Generate();
        }

        private static Company CreateCompany()
        {
            var fakeCompany = new Faker<Company>()
                .RuleFor(cp => cp.Name, f => f.Company.CompanyName())
                .RuleFor(cp => cp.Address, f => f.Address.StreetAddress())
                .RuleFor(cp => cp.City, f => f.Address.City())
                .RuleFor(cp => cp.Country, f => f.Address.Country());
            return fakeCompany.Generate();
        }
    }
}