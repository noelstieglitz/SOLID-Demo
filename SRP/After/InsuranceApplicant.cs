using System;

namespace After
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
        public decimal Income { get; protected set; }
        public Guid Id { get; protected set; }
        public decimal Premium { get; protected set; }

        public void CalculatePremium()
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