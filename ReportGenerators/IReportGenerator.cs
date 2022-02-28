using System.Collections.Generic;
using Bogus;

namespace CandidatesAndEmployees
{
    public interface IReportGenerator<T>
    {
        public void GenerateReport(List<T> persons);
    }
}