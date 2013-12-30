using System.Collections.Generic;

namespace After
{
    public class ApplicantRepository
    {
        public ApplicantRepository()
        {
            Applicants = new HashSet<InsuranceApplicant>();
        }

        private HashSet<InsuranceApplicant> Applicants { get; set; }

        public void Save(InsuranceApplicant applicant)
        {
            Applicants.Add(applicant);
        }
    }
}