namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new InusranceController(new ApplicantRepository());

            controller.Run();
        }
    }
}
