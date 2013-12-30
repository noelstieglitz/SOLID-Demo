using System;

namespace Before
{
    public class InusranceController
    {
        public void Run()
        {
            Console.WriteLine("Starting up...");

            var repository = new ApplicantRepository();

            var mexicoInsuranceApplicant = new MexicoInsuranceApplicant(new DateTime(1973, 1, 13), 46000);

            Console.WriteLine("Calculating premium for Mexico applicants...");

            mexicoInsuranceApplicant.CalculatePremium();

            Console.WriteLine("Premium is {0}", mexicoInsuranceApplicant.Premium);

            Console.WriteLine("Saving to store...");
            repository.Save(mexicoInsuranceApplicant);

            Console.WriteLine("Calculating premium for Canada applicants...");
            var canadaInsuranceApplicant = new CanadaInsuranceApplicant(new DateTime(1973, 1, 13), 46000);
            canadaInsuranceApplicant.CalculatePremium();
            Console.WriteLine("Premium is {0}", canadaInsuranceApplicant.Premium);

            Console.WriteLine("Saving to store...");
            repository.Save(canadaInsuranceApplicant);
            Console.WriteLine("Done.");

            Console.Read();
        }
    }
}