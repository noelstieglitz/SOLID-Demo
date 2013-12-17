using System;
using System.Collections.Generic;

namespace Before
{
    public class InsuranceApplicant
    {
        public InsuranceApplicant(DateTime bornOnDate, decimal income)
        {
            BornOnDate = bornOnDate;
            Income = income;
            Id = Guid.NewGuid();

            Applicants = new HashSet<InsuranceApplicant>();
        }

        public HashSet<InsuranceApplicant> Applicants { get; set; }

        public DateTime BornOnDate { get; protected set; }
        public decimal Income { get; protected set; }
        public Guid Id { get; protected set; }
        public decimal Premium { get; protected set; }

        public void CalculatePremium()
        {
            if (BornOnDate.Year <= 1950)
            {
                Premium = 1200m;
            }
            else
            {
                Premium = 500m;
            }
        }

        public void SaveToStore()
        {
            Applicants.Add(this);
        }
    }
}