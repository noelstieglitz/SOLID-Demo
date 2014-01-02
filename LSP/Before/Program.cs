namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new NissanLeaf();

            car.GetGas(0); //What do I pass here?  It's confusing for the caller.
        }
    }
}
