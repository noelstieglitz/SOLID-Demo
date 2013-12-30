namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new InusranceController(new InsuranceApplicantRepository());

            ui.Run();
        }
    }
}
