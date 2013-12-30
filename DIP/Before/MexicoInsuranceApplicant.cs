using System;

namespace Before
{
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
}