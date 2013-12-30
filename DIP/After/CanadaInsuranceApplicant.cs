using System;

namespace After
{
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