namespace Before
{
    public class NissanLeaf : Car
    {
        public void ChargeBattery(ChargePercent chargePercent)
        {
            //...
        }

        public override void GetGas(decimal gallons)
        {
            //NissanLeaf doesn't use gas
            //We aren't really sure how much we want to charge?
            ChargeBattery(ChargePercent.OneHundred);
        }
    }

    public enum ChargePercent
    {
        TwentyFive,
        Fifty,
        SeventyFive,
        OneHundred
    }
}