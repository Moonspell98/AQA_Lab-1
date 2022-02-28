using System;
using System.Collections;
using System.Collections.Generic;
using Bogus;

namespace CandidatesAndEmployees
{
    public class EmployeeReportGenerator : IReportGenerator<Employee>
    {
        public void GenerateReport(List<Employee> employees)
        {
            employees.Sort(new EmployeesComparer());
            Console.WriteLine("| {0, 37} | {1, 35} | {2, 25} | {3, 6} |", "Employee Id", "Company Name", "Employee Full Name", "Salary");
            foreach (var employee in employees)
            {
                Console.WriteLine("| {0, 37} | {1, 35} | {2, 25} | {3, 6} |", employee.id, employee.Company.Name, employee.Name + " " + employee.Surname, employee.Salary);
            }
        }
    }
}