namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new NissanLeaf();

            car.Refuel(0); //What do I pass here?  It's confusing for the caller.
        }
    }
}
