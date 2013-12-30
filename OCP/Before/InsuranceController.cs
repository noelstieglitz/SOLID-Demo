using System;

namespace Before
{
    public class InsuranceController
    {
        public void Run()
        {
            Console.WriteLine("Starting up...");

            var repository = new ApplicantRepository();

            var mexicoInsuranceApplicant = new InsuranceApplicant(new DateTime(1973, 1, 13), 46000);

            Console.WriteLine("Calculating premium for Mexico applicants...");

            mexicoInsuranceApplicant.CalculatePremium(false);

            Console.WriteLine("Premium is {0}", mexicoInsuranceApplicant.Premium);

            Console.WriteLine("Saving to store...");
            repository.Save(mexicoInsuranceApplicant);

            Console.WriteLine("Calculating premium for Canada applicants...");
            var canadaInsuranceApplicant = new InsuranceApplicant(new DateTime(1973, 1, 13), 46000);
            canadaInsuranceApplicant.CalculatePremium(true);
            Console.WriteLine("Premium is {0}", canadaInsuranceApplicant.Premium);

            Console.WriteLine("Saving to store...");
            repository.Save(canadaInsuranceApplicant);
            Console.WriteLine("Done.");

            Console.Read();
        }
    }
}