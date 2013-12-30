using System;

namespace After
{
    public class InsuranceController
    {
        public void Run()
        {
            Console.WriteLine("Starting up...");
            var applicant = new InsuranceApplicant(new DateTime(1973, 1, 13), 46000);

            Console.WriteLine("Calculating premium...");
            applicant.CalculatePremium();
            Console.WriteLine("Premium is {0}", applicant.Premium);

            Console.WriteLine("Saving to store...");
            var repository = new ApplicantRepository();
            repository.Save(applicant);
            Console.WriteLine("Done.");

            Console.Read();
        }
    }
}