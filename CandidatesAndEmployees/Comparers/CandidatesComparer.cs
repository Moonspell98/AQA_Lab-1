using System;
using System.Collections;
using System.Collections.Generic;

namespace CandidatesAndEmployees
{
    public class CandidatesComparer : IComparer<Candidate>
    {
        public int Compare(Candidate x, Candidate y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            var desiredPositionComparison = string.Compare(x.DesiredPosition, y.DesiredPosition, StringComparison.Ordinal);
            if (desiredPositionComparison != 0) return desiredPositionComparison;
            return x.DesiredSalary.CompareTo(y.DesiredSalary);
        }
    }
}