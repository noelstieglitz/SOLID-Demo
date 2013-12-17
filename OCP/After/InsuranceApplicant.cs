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

    public class MexicoInsuranceApplicant : InsuranceApplicant
    {
        public MexicoInsuranceApplicant(DateTime bornOnDate, decimal income)
            : base(bornOnDate, income)
        {
        }

        public override void CalculatePremium()
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

    public class CanadaInsuranceApplicant : InsuranceApplicant
    {
        public CanadaInsuranceApplicant(DateTime bornOnDate, decimal income)
            : base(bornOnDate, income)
        {
        }

        public override void CalculatePremium()
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
    }
}