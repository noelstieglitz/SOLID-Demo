﻿using System.Collections.Generic;

namespace After
{
    public class ApplicantRepository
    {
        private static readonly HashSet<InsuranceApplicant> Applicants = new HashSet<InsuranceApplicant>();

        public void Save(InsuranceApplicant applicant)
        {
            Applicants.Add(applicant);
        }
    }
}