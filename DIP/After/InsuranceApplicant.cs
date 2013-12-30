using System;

namespace After
{
    public abstract class InsuranceApplicant
    {
        protected InsuranceApplicant(DateTime bornOnDate, decimal income)
        {
            BornOnDate = bornOnDate;
            Income = income;
            Id = Guid.NewGuid();
        }

        public DateTime BornOnDate { get; protected set; }
        public Guid Id { get; protected set; }
        public decimal Premium { get; protected set; }
        public decimal Income { get; protected set; }

        public abstract void CalculatePremium();

    }
}