using System.Collections.Generic;

namespace Before
{
    public class InsuranceApplicantRepository
    {
        public InsuranceApplicantRepository()
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