using System;
using System.Collections;
using System.Collections.Generic;

namespace CandidatesAndEmployees
{
    public class EmployeesComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            var companyNameComparison = string.Compare(x.Company.Name, y.Company.Name, StringComparison.Ordinal);
            if (companyNameComparison != 0) return companyNameComparison;
            return x.Salary.CompareTo(y.Salary);
        }
    }
}