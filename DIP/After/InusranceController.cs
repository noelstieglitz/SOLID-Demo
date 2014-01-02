using System;

namespace After
{
    public class InusranceController
    {
        private readonly IApplicantRepository _repository;

        public InusranceController(IApplicantRepository repository)
        {
            _repository = repository;
        }

        public void Run()
        {
            Console.WriteLine("Starting up...");

            var mexicoInsuranceApplicant = new MexicoInsuranceApplicant(new DateTime(1973, 1, 13), 46000);

            Console.WriteLine("Calculating premium for Mexico applicants...");

            mexicoInsuranceApplicant.CalculatePremium();

            Console.WriteLine("Premium is {0}", mexicoInsuranceApplicant.Premium);

            Console.WriteLine("Saving to store...");
            _repository.Save(mexicoInsuranceApplicant);

            Console.WriteLine("Calculating premium for Canada applicants...");
            var canadaInsuranceApplicant = new CanadaInsuranceApplicant(new DateTime(1973, 1, 13), 46000);
            canadaInsuranceApplicant.CalculatePremium();
            Console.WriteLine("Premium is {0}", canadaInsuranceApplicant.Premium);

            Console.WriteLine("Saving to store...");
            _repository.Save(canadaInsuranceApplicant);
            Console.WriteLine("Done.");

            Console.Read();
        }
    }
}