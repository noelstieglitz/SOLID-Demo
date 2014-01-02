using System;

namespace Before
{
    public class InsuranceController
    {
        public void Run()
        {
            Console.WriteLine("Starting up...");
            var applicant = new InsuranceApplicant(new DateTime(1973, 1, 13), 32000);

            Console.WriteLine("Calculating premium...");
            applicant.CalculatePremium();
            Console.WriteLine("Premium is {0}", applicant.Premium);

            Console.WriteLine("Saving to store...");
            applicant.SaveToStore();
            Console.WriteLine("Done.");

            Console.Read();
        }
    }
}