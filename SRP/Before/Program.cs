using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before
{
    class Program
    {
        static void Main(string[] args)
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
