using System;
using System.Collections.Generic;

namespace After
{
    public class InsuranceApplicant
    {
        public InsuranceApplicant(DateTime bornOnDate)
        {
            BornOnDate = bornOnDate;
            Id = Guid.NewGuid();
        }

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
    }

    public class InsuranceApplicantRepository
    {
        public HashSet<InsuranceApplicant> Applicants { get; set; }
        public void Save(InsuranceApplicant applicant)
        {
            Applicants.Add(applicant);
        }
    }
}