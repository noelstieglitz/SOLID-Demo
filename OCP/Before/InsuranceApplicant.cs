using System;

namespace Before
{
    public class InsuranceApplicant
    {
        public InsuranceApplicant(DateTime bornOnDate, decimal income)
        {
            BornOnDate = bornOnDate;
            Income = income;
            Id = Guid.NewGuid();
        }

        public DateTime BornOnDate { get; protected set; }
        public Guid Id { get; protected set; }
        public decimal Premium { get; protected set; }
        public decimal Income { get; protected set; }

        public void CalculatePremium(bool calculateForCanada)
        {
            if (calculateForCanada)
            {
                if (BornOnDate.Year <= 1970 || this.Income < 33000m)
                {
                    this.Premium = 400m;
                }
                else
                {
                    this.Premium = 600m;
                }
            }
            else
            {
                if (BornOnDate.Year <= 1950)
                {
                    this.Premium = 1200m;
                }
                else
                {
                    this.Premium = 500m;
                }
            }
        }
    }
}