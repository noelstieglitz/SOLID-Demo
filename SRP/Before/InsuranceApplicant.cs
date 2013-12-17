using System;
using System.Collections.Generic;

namespace Before
{
    public class InsuranceApplicant
    {
        public InsuranceApplicant(DateTime bornOnDate)
        {
            BornOnDate = bornOnDate;
            Id = Guid.NewGuid();
        }

        public HashSet<InsuranceApplicant> Applicants { get; set; }

        public DateTime BornOnDate { get; private set; }
        public Guid Id { get; set; }

        public decimal CalculatePremium()
        {
            if (BornOnDate.Year <= 1950)
            {
                return 1000m;
            }

            return 500m;
        }

        public void SaveToRepository()
        {
            Applicants.Add(this);
        }
    }
}