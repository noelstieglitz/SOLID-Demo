﻿using System.Collections.Generic;

namespace After
{
    public class InsuranceApplicantRepository
    {
        public InsuranceApplicantRepository()
        {
            Applicants = new HashSet<InsuranceApplicant>();
        }

        public HashSet<InsuranceApplicant> Applicants { get; set; }

        public void Save(InsuranceApplicant applicant)
        {
            Applicants.Add(applicant);
        }
    }
}