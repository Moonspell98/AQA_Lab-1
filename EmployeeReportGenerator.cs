using System;
using System.Collections;
using System.Collections.Generic;

namespace CandidatesAndEmployees
{
    public class EmployeeReportGenerator : IReportGenerator
    {
        public void GenerateReport(List<Employee> employees)
        {
            employees.Sort(new EmployeesComparer());
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Company.Name + " " + employee.Salary + " " + employee.Name);
                Console.WriteLine();
            }
        }
    }
}