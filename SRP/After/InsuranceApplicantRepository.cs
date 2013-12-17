using System.Collections.Generic;

namespace After
{
    public class InsuranceApplicantRepository
    {
        public HashSet<InsuranceApplicant> Applicants { get; set; }

        public void Save(InsuranceApplicant applicant)
        {
            Applicants.Add(applicant);
        }
    }
}