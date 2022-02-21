using System;

namespace CandidatesAndEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
           var employees =  RandomPersonsGenerator.GenerateEmployees();
           var employeeReport = new EmployeeReportGenerator();
           employeeReport.GenerateReport(employees);
        }
    }
}