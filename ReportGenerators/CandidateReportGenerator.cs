using System;
using System.Collections.Generic;

namespace CandidatesAndEmployees
{
    public class CandidateReportGenerator : IReportGenerator<Candidate>
    {
        public void GenerateReport(List<Candidate> candidates)
        {
            candidates.Sort(new CandidatesComparer());
            Console.WriteLine("| {0, 37} | {1, 25} | {2, 45} | {3, 6} |", "Candidate Id", "Candidate Full Name", "Job Title", "Salary");
            foreach (var candidate in candidates)
            {
                Console.WriteLine("| {0, 37} | {1, 25} | {2, 45} | {3, 6} |", candidate.id, candidate.Name + " " + candidate.Surname, candidate.DesiredPosition, candidate.DesiredSalary);
            }
        }
    }
}