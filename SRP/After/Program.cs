using System;

namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting up...");
            var applicant = new InsuranceApplicant(new DateTime(1973, 1, 13), 46000);

            Console.WriteLine("Calculating premium...");
            applicant.CalculatePremium();
            Console.WriteLine("Premium is {0}", applicant.Premium);

            Console.WriteLine("Saving to store...");
            var repository = new InsuranceApplicantRepository();
            repository.Save(applicant);
            Console.WriteLine("Done.");

            Console.Read();
        }
    }
}
